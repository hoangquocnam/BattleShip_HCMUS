using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipServer
{
    static class Encrypt
    {
        public static string StringToHex(string src)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(src);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString();
        }
        
        public static string HexToString(string src)
        {
            var bytes = new byte[src.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(src.Substring(i * 2, 2), 16);
            }
            return Encoding.Unicode.GetString(bytes);
        }
    }
}
