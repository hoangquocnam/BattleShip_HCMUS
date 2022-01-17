using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace BattleshipServer
{
    public class ClientInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Note { get; set; }
        public int Point { get; set; }

        public StringBuilder[] Map = new StringBuilder[20];

        public bool isInGame = false;

        public ClientInfo()
        {
            Username = string.Empty;
            Password = string.Empty;
            FullName = string.Empty;
            DateOfBirth = string.Empty;
            Note = string.Empty;
            Point = 0;
            
        }

        public ClientInfo(string username, string password, string fullName, string dateOfBirth, string note, int point)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Note = note;
            Point = point;
        }
    }

    public class Client
    {
        public Socket socket;
        public ClientInfo info;
        public byte[] buffers;
        public StringBuilder sb = new StringBuilder();

        public Client(Socket clientSocket)
        {
            socket = clientSocket;
            info = null;
            buffers = new byte[2048];
            sb = new StringBuilder();
        }

        public string GetName()
        {
            if (info == null)
                return socket.RemoteEndPoint.ToString();

            return info.Username;
        }
    }
    
    public class ROOM
    {
        public Client host;
        public Client guest;
        public string isContinueHost = "";
        public string isContinueGuest = "";
    }
}
