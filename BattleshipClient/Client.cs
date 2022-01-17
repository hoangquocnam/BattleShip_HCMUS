using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace BattleshipClient
{
    public class ClientInfo
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Note { get; set; }
        public int Point { get; set; }

        public ClientInfo()
        {
            Username = string.Empty;
            FullName = string.Empty;
            DateOfBirth = string.Empty;
            Note = string.Empty;
            Point = 0;
        }

        public ClientInfo(string username, string fullName, string dateOfBirth, string note, int point)
        {
            Username = username;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Note = note;
            Point = point;
        }
    }

    class Client
    {
        public Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public ClientInfo info;
        public byte[] buffers = new byte[2048];
        public StringBuilder sb = new StringBuilder();
        public void Clear()
        {
            info = null;
            Array.Clear(buffers, 0, buffers.Length);
            sb.Clear();
        }
    }

    
}
