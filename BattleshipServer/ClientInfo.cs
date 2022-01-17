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
        public string DOB { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public int Point { get; set; }
        public ClientInfo(string username, string password, string fullname, string dob, string note, string status, int point)
        {
            Username = username;
            Password = password;
            FullName = fullname;
            DOB = dob;
            Note = note;
            Status = status;
            Point = point;
        }
        public ClientInfo()
        {
            Username = string.Empty;
            Password = string.Empty;
            FullName = string.Empty;
            DOB = string.Empty;
            Note = string.Empty;
            Status = string.Empty;
            Point = 0;
        }
    }

    class Client
    {
        public Socket socket;
        public ClientInfo info = new ClientInfo();
        public byte[] buffers = new byte[1024];
        public StringBuilder sb = new StringBuilder();

        public Client(Socket clientSocket)
        {
            socket = clientSocket;
        }
    }
}
