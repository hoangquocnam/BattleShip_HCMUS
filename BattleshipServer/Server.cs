using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Drawing;

namespace BattleshipServer
{
    public class Server
    {
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private List<Client> clientList = new List<Client>();
        private DatabaseAccessor dbAccessor = new DatabaseAccessor();
        private bool isDispose = false;
        private List<ROOM> roomlist = new List<ROOM>();

        #region Socket Handler

        public void Start(int backlog = 10)
        {
            if (isDispose)
            {
                isDispose = false;
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 5555));
            serverSocket.Listen(backlog);
            serverSocket.BeginAccept(AcceptCallback, null);
            FormMain.Instance.AddLog($"Server started", Color.Green);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = serverSocket.EndAccept(ar);
                Client client = new Client(clientSocket);
                FormMain.Instance.AddLog($"New connect at {client.socket.RemoteEndPoint}");
                clientList.Add(client);
                client.socket.BeginReceive(client.buffers, 0, client.buffers.Length, SocketFlags.None, ReceiveCallback, client);
                serverSocket.BeginAccept(AcceptCallback, null);
            }
            catch (ObjectDisposedException)
            {
                // server stop (disposed)
            }
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            Client client = (Client)result.AsyncState;

            try
            {
                int bufferSize = client.socket.EndReceive(result);

                if (bufferSize != 0)
                {
                    byte[] packet = new byte[bufferSize];
                    Array.Copy(client.buffers, packet, packet.Length);

                    client.sb.Append(Encoding.UTF8.GetString(packet));

                    string s = client.sb.ToString();

                    // đã nhận đủ gói tin
                    while (s.IndexOf("<EOF>") != -1)
                    {
                        string request = s.Substring(0, s.IndexOf("<EOF>"));
                        s = s.Substring(s.IndexOf("<EOF>") + 5);

                        if (request == "exit")
                        {
                            HandleClientDisconnect(client);
                            return;
                        }

                        ProcessPacket(client, request);
                    }

                    client.sb.Clear();
                    client.sb.Append(s);
                    client.socket.BeginReceive(client.buffers, 0, client.buffers.Length, SocketFlags.None, ReceiveCallback, client);
                }
            }
            catch (Exception)
            {
                if (!isDispose)
                {
                    // client forcibly exit
                    HandleClientDisconnect(client);
                }
            }
        }

        private void SendResponse(Client client, string response)
        {
            client.socket.Send(Encoding.UTF8.GetBytes(response + "<EOF>"));
        }

        public void Stop()
        {
            isDispose = true;

            foreach (Client client in clientList)
            {
                SendResponse(client, "exit");
                if (client.socket.Connected)
                    client.socket.Shutdown(SocketShutdown.Both);
                client.socket.Close();
            }

            clientList.Clear();

            FormMain.Instance.ClearList();

            if (serverSocket.Connected)
            {
                serverSocket.Shutdown(SocketShutdown.Both);
            }

            serverSocket.Close();
            FormMain.Instance.AddLog($"Server stopped", Color.Red);
        }

        #endregion

        #region Packet Handler

        private void ProcessPacket(Client client, string request)
        {
            string[] tokens = request.Split('\0');
            switch (tokens[0])
            {
                case "login":
                    HandleLoginRequest(client, tokens);
                    break;

                case "logout":
                    HandleLogoutRequest(client);
                    break;

                case "signup":
                    HandleSignUpRequest(client, tokens);
                    break;

                case "setup_info":
                    HandleUpdateInfoRequest(client, tokens);
                    break;

                case "changepassword":
                    HandleChangePasswordRequest(client, tokens);
                    break;

                case "search":
                    HandleSearchRequest(client, tokens);
                    break;

                case "invite":
                    HandleInviteRequest(client, tokens);
                    break;

                case "game":
                    HandleGamingRequest(client, tokens);
                    break;

                case "chat":
                    HandleChatRequest(client, tokens);
                    break;

            }
        }

        private void HandleLoginRequest(Client client, string[] tokens)
        {
            string username = tokens[1];
            string password = tokens[2];

            if (tokens[3] == "1") // encrypted
            {
                username = Encrypt.HexToString(username);
                password = Encrypt.HexToString(password);
            }

            List<ClientInfo> infoList = dbAccessor.GetData();

            for (int i = 0; i < infoList.Count(); i++)
            {
                if (infoList[i].Username == username && infoList[i].Password == password)
                {
                    if (!isOnline(username))
                    {
                        client.info = infoList[i];

                        #region Send successful login response to current client

                        if (tokens[3] == "1")
                        {
                            SendResponse(client, $"login\01\01\0{Encrypt.StringToHex(client.info.Username)}\0{client.info.FullName}\0{client.info.DateOfBirth}\0{client.info.Note}\0{client.info.Point}");
                        }
                        else
                        {
                            SendResponse(client, $"login\01\00\0{client.info.Username}\0{client.info.FullName}\0{client.info.DateOfBirth}\0{client.info.Note}\0{client.info.Point}");
                        }

                        #endregion

                        #region Send online list to current client

                        StringBuilder onlineList = new StringBuilder();
                        onlineList.Append("online");

                        var onlineClient = clientList.Where((p) => { return p.info != null && p.info.Username != client.info.Username; }).Select((p) => { return p.info.Username; });

                        foreach (var item in onlineClient)
                        {
                            onlineList.Append("\0");
                            onlineList.Append(item.ToString());
                        }

                        // online\0username1\0username2\0...
                        SendResponse(client, onlineList.ToString());

                        #endregion

                        #region Send current client to other online client

                        var otherLoggedInClients = clientList.Where((p) => { return p.info != null && p.info.Username != client.info.Username; });

                        foreach (Client item in otherLoggedInClients)
                        {
                            SendResponse(item, $"online\0{client.info.Username}");
                        }

                        #endregion

                        FormMain.Instance.AddLog($"{client.info.Username} logged in with username \"{client.info.Username}\"");
                        FormMain.Instance.AddToList(client.info.Username);

                        return;
                    }
                    else
                    {
                        SendResponse(client, "login\00\0User is now online.");
                        return;
                    }
                }
            }

            SendResponse(client, "login\00\0The username and/or password you specified are not correct.");
        }

        private void HandleLogoutRequest(Client client)
        {
            var otherLoggedInClients = clientList.Where((p) => { return p.info != null && p.info.Username != client.info.Username; });

            foreach (Client item in otherLoggedInClients)
            {
                SendResponse(item, $"offline\0{client.info.Username}");
            }
            FormMain.Instance.AddLog($"{client.info.Username} logged out");
            FormMain.Instance.RemoveFromList(client.info.Username);
            client.info = null;
        }

        private void HandleSignUpRequest(Client client, string[] tokens)
        {
            string username = tokens[2];
            string password = tokens[3];
            string fullName = tokens[4];
            string dateOfBirth = tokens[5];
            string note = tokens[6];

            if (tokens[1] == "1")
            {
                username = Encrypt.HexToString(username);
                password = Encrypt.HexToString(password);
            }

            List<ClientInfo> infoList = dbAccessor.GetData();

            foreach (ClientInfo info in infoList)
            {
                if (info.Username == username)
                {
                    FormMain.Instance.AddLog($"{client.socket.RemoteEndPoint} have failed to sign up account {username}");
                    SendResponse(client, "signup\00");
                    return;
                }
            }

            SendResponse(client, "signup\01");
            ClientInfo i = new ClientInfo(username, password, fullName, dateOfBirth, note, 0);
            dbAccessor.Insert(i);
            FormMain.Instance.AddLog($"{client.socket.RemoteEndPoint} have successfully signed up an account with username {i.Username}");
        }

        private void HandleUpdateInfoRequest(Client client, string[] tokens, bool win = false)
        {
            if (win) client.info.Point++;
            else
            {
                client.info.FullName = tokens[1];
                client.info.DateOfBirth = tokens[2];
                client.info.Note = tokens[3];
            }
            dbAccessor.Update(client.info);
            FormMain.Instance.AddLog($"{client.info.Username} updated information successfully");
        }

        private void HandleChangePasswordRequest(Client client, string[] tokens)
        {
            if (tokens[1] == "1")
            {
                tokens[2] = Encrypt.HexToString(tokens[2]);
                tokens[3] = Encrypt.HexToString(tokens[3]);
            }
            if (tokens[2] == client.info.Password)
            {
                if (tokens[3] != tokens[2])
                {
                    client.info.Password = tokens[3];
                    dbAccessor.Update(client.info);
                    FormMain.Instance.AddLog($"{client.info.Username} changed password successfully");
                    SendResponse(client, $"changepassword\01");
                }
                else
                {
                    SendResponse(client, $"changepassword\00\0The new password must to be different than the old one!");
                }
            }
            else
            {
                SendResponse(client, $"changepassword\00\0The current password is wrong");
            }

        }

        private void HandleSearchRequest(Client client, string[] tokens)
        {
            string username = tokens[1];
            string field = tokens[2];

            FormMain.Instance.AddLog($"{client.info.Username} searched for {username}'s information");

            List<ClientInfo> infoList = dbAccessor.GetData();

            foreach (ClientInfo info in infoList)
            {
                if (info.Username == username)
                {
                    string status = isOnline(username) ? "online" : "offline";

                    switch (field)
                    {
                        case "all":
                            SendResponse(client, $"search\01\0{info.FullName}\0{info.DateOfBirth}\0{status}\0{info.Point}\0{info.Note}");
                            break;

                        case "fullname":
                            SendResponse(client, $"search\01\0{info.FullName}\0\0\0\0");
                            break;

                        case "dob":
                            SendResponse(client, $"search\01\0\0{info.DateOfBirth}\0\0\0");
                            break;

                        case "status":
                            SendResponse(client, $"search\01\0\0\0{status}\0\0");
                            break;

                        case "point":
                            SendResponse(client, $"search\01\0\0\0\0{info.Point}\0");
                            break;

                        case "note":
                            SendResponse(client, $"search\01\0\0\0\0\0{info.Note}");
                            break;

                    }

                    return;
                }
            }

            SendResponse(client, $"search\00");
        }

        private void HandleChatRequest(Client client, string[] tokens)
        {
            string msg = tokens[1];

            FormMain.Instance.AddLog($"{client.info.Username} chat {msg}");

            foreach (Client item in clientList)
            {
                if (!item.Equals(client) && item.info != null)
                {
                    SendResponse(item, $"chat\0{client.info.Username}: {msg}");
                }
            }
        }

        private void HandleInviteRequest(Client client, string[] tokens)
        {
            switch (tokens[1])
            {
                case "username":
                    var invitee = clientList.Where((item) => { return item.info.Username == tokens[2] && item != null; }).First();
                    if (!invitee.info.isInGame)
                    {
                        SendResponse(invitee, $"invite\0quest\0{client.info.Username}\0{tokens[2]}");
                        FormMain.Instance.AddLog($"{client.info.Username} invited {tokens[2]}");
                    }
                    else SendResponse(client, $"invite\0ingame\0{client.info.Username}\0{tokens[2]}");
                    break;

                case "1":
                    var accepter = clientList.Where((item) => { return item != null && item.info.Username == tokens[3] && item.info.Username != client.info.Username; }).First();
                    accepter.info.isInGame = true;
                    client.info.isInGame = true;
                    ROOM room = CreateRoom(accepter, client);
                    roomlist.Add(room);
                    SendResponse(client, $"invite\01\0{tokens[3]}\0{client.info.Username}\0{Convert.ToString(roomlist.IndexOf(room))}");
                    SendResponse(accepter, $"invite\01\0{client.info.Username}\0{tokens[2]}\0{Convert.ToString(roomlist.IndexOf(room))}");
                    FormMain.Instance.AddLog($"Battleship - Room {Convert.ToString(roomlist.IndexOf(room))} - Host: {room.host.info.Username} - Guest: {room.guest.info.Username}");
                    break;

                case "0":
                    var denider = clientList.Where((item) => { return item != null && item.info.Username == tokens[3] && item.info.Username != client.info.Username; }).First();
                    SendResponse(denider, $"invite\00\0{client.info.Username}\0{tokens[2]}");
                    FormMain.Instance.AddLog($"{client.info.Username} refused {tokens[2]}");
                    break;
            }

        }

        private void HandleClientDisconnect(Client client)
        {
            if (client.info != null)
            {
                var otherClients = clientList.Where((p) => { return p.info != null && p.info.Username != client.info.Username; });

                foreach (Client item in otherClients)
                {
                    SendResponse(item, $"offline\0{client.info.Username}");
                }
            }

            if (client.info != null) FormMain.Instance.RemoveFromList(client.info.Username);
            FormMain.Instance.AddLog($"{client.GetName()} disconnected", Color.DarkOrange);
            clientList.Remove(client);
            if (client.socket.Connected) client.socket.Shutdown(SocketShutdown.Both);
            client.socket.Close();
        }

        private void HandleGamingRequest(Client client, string[] tokens)
        {
            int roomID = int.Parse(tokens[1]);
            ROOM room = roomlist[roomID];
            switch (tokens[2])
            {
                case "grid":
                    StringBuilder[] grid = GetGrid(tokens);
                    client.info.Map = grid;
                    if (room.host.info.Map[0] != null) SendResponse(room.guest, $"game\0ready");
                    if (room.guest.info.Map[0] != null) SendResponse(room.host, $"game\0ready");
                    if (room.host.info.Map[0] != null && room.guest.info.Map[0] != null) Turn(room.host, room.guest);
                    break;

                case "click":
                    PlayerHit(room, client, tokens);
                    break;

                case "timeout":
                    if (room.host == client) Turn(room.guest, room.host);
                    else Turn(room.host, room.guest);
                    break;

                case "surrender":
                    if (room.host == client) ResultResponse(room.guest, room.host, room);
                    else ResultResponse(room.host, room.guest, room);
                    break;

                case "continue":
                    string rep;
                    if (tokens[3] == "1") rep = "1";
                    else rep = "0";
                    if (client == room.guest) room.isContinueGuest = rep;
                    if (client == room.host) room.isContinueHost = rep;
                    if (room.isContinueGuest == "1" && room.isContinueHost == "1")
                    {
                        room.isContinueHost = "";
                        room.isContinueGuest = "";
                        SendResponse(room.host, $"invite\01\0{room.guest.info.Username}\0{room.host.info.Username}\0{Convert.ToString(roomID)}");
                        SendResponse(room.guest, $"invite\01\0{room.host.info.Username}\0{room.guest.info.Username}\0{Convert.ToString(roomID)}");
                    }
                    else if (room.isContinueGuest == "1" && room.isContinueHost == "0")
                    {
                        EndGameResponse(room, "g");
                    }
                    else if (room.isContinueHost == "1" && room.isContinueGuest == "0")
                    {
                        EndGameResponse(room, "h");
                    }
                    else if (room.isContinueHost == "0" && room.isContinueGuest == "0")
                    {
                        EndGameResponse(room);
                    }
                    break;

                case "chat":
                    if (room.host == client)
                    {
                        GameChatRequest(client, room.guest, tokens);
                    }
                    else GameChatRequest(client, room.host, tokens);
                    break;
            }
        }

        #region Gaming Accessibility

        void PlayerHit(ROOM room, Client client, string[] tokens)
        {
            string Y = Convert.ToString(int.Parse(tokens[3]) + 1);
            string X = Convert.ToString(int.Parse(tokens[4]) + 1);
            if (room.host == client)
            {
                if (room.guest.info.Map[int.Parse(tokens[3])][int.Parse(tokens[4])] == '1')
                {
                    // Y - X
                    room.guest.info.Map[int.Parse(tokens[3])][int.Parse(tokens[4])] = '0';
                    if (isBeaten(room.guest.info.Map)) ResultResponse(room.host, room.guest, room);
                    else
                    {
                        // X - Y
                        SendResponse(room.host, $"game\0hit\0{X}\0{Y}");
                        SendResponse(room.guest, $"game\0clicked\0{X}\0{Y}\01");
                    }

                }
                // X - Y (miss)
                else SendResponse(room.guest, $"game\0clicked\0{X}\0{Y}\00");
            }
            else
            {
                if (room.host.info.Map[int.Parse(tokens[3])][int.Parse(tokens[4])] == '1')
                {
                    // Y - X
                    room.host.info.Map[int.Parse(tokens[3])][int.Parse(tokens[4])] = '0';
                    if (isBeaten(room.host.info.Map))
                    {
                        ResultResponse(room.guest, room.host, room);
                    }
                    else
                    {
                        // X - Y
                        SendResponse(room.guest, $"game\0hit\0{X}\0{Y}");
                        SendResponse(room.host, $"game\0clicked\0{X}\0{Y}\01");
                    }

                }
                // X - Y (miss)
                else SendResponse(room.host, $"game\0clicked\0{X}\0{Y}\00");
            }
        }

        private StringBuilder[] GetGrid(string[] tokens)
        {
            StringBuilder[] grid = new StringBuilder[20];
            for (int i = 0; i < 20; i++)
            {
                grid[i] = new StringBuilder();
                grid[i].AppendLine(tokens[i + 4]);
            }
            return grid;
        }

        private ROOM CreateRoom(Client host, Client guest)
        {
            ROOM room = new ROOM();
            room.host = host;
            room.guest = guest;
            return room;
        }

        private bool isBeaten(StringBuilder[] grid)
        {
            for (int i = 0; i < 20; i++)
            {
                if (grid[i].ToString().Contains('1')) return false;
            }
            return true;
        }

        void ResultResponse(Client winner, Client loser, ROOM room)
        {
            HandleUpdateInfoRequest(winner, null, true);
            SendResponse(winner, $"game\0win\0{loser.info.Username}");
            SendResponse(loser, $"game\0lose\0{winner.info.Username}");
        }

        void Turn(Client player1, Client player2)
        {
            SendResponse(player1, $"game\0turn\01");
            SendResponse(player2, $"game\0turn\00");
        }

        private void GameChatRequest(Client client, Client player, string[] tokens)
        {
            string msg = tokens[3];
            SendResponse(player, $"game\0chat\0{client.info.Username}: {msg}");
        }

        private void EndGameResponse(ROOM room, string who = "both")
        {
            if (who == "both")
            {
                if (room.guest.info != null)
                {
                    room.guest.info.isInGame = false;
                    SendResponse(room.guest, $"game\0end\00");
                }
                if (room.host.info != null)
                {
                    room.host.info.isInGame = false;
                    SendResponse(room.host, $"game\0end\00");
                }
                
            }
            if (who == "g")
            {
                if (room.guest.info != null)
                {
                    room.guest.info.isInGame = false;
                    SendResponse(room.guest, $"game\0end\01");
                }
                if (room.host.info != null)
                {
                    room.host.info.isInGame = false;
                    SendResponse(room.host, $"game\0end\00");
                }
            }
            if (who == "h")
            {
                if (room.guest.info != null)
                {
                    room.guest.info.isInGame = false;
                    SendResponse(room.guest, $"game\0end\00");
                }
                if (room.host.info != null)
                {
                    room.host.info.isInGame = false;
                    SendResponse(room.host, $"game\0end\01");
                }

            }
            roomlist.Remove(room);
        }

        #endregion
        private bool isOnline(string username)
        {
            foreach (Client client in clientList)
            {
                if (client.info != null && client.info.Username == username)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
