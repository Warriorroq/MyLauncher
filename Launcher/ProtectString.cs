using System;
using System.Linq;
using System.Text;

namespace Launcher
{
    public static class ProtectString
    {
        private static ushort _secretKey = 0x0089;
        public static string Encode(string data)
        {
            return EncodeDecrypt(data, _secretKey);
        }
        private static string EncodeDecrypt(string str, ushort secretKey)
        {
            var ch = str.ToArray();
            string newStr = "";    
            foreach (var c in ch)
                newStr += XOROperation(c, secretKey);
            return newStr;
        }
        private static char XOROperation(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey);
            return character;
        }
    }
}
