using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOR_Cipher
{
    public class XOR
    {
        private char _char;
        private string CharBinary;
        private string KeyBinary;
        private string XOR_;

        public XOR(char @char)
        {
            _char = @char; // 'z'
            KeyBinary = "01010101";
        }

        // 01111010 -> 'z' binary
        // 01010101 -> randomized key
        // 00101111 -> XOR

        public void GetBinaryCharCode()
        {
            int charCode = Convert.ToInt32(_char);
            string binaryCharCode = Convert.ToString(charCode, 2);
            CharBinary = '0' + binaryCharCode;
        }

        public void Create_XOR_Cipher()
        {
            string xor = "";
            for (int i = 0; i < CharBinary.Length; i++)
            {
                char charBit = CharBinary[i];
                char keyBit = KeyBinary[i];
                if (charBit == '0' & keyBit == '0' || charBit == '1' & keyBit == '1')
                {
                    xor += '0';
                }
                else
                {
                    xor += '1';
                }
            }
            XOR_ = xor;
        }

        public void Print_XOR()
        {
            Console.Write(XOR_);
        }
    }
}
