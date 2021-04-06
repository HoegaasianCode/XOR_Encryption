using System;

namespace XOR_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            XOR xor = new('z');
            xor.GetBinaryCharCode();
            xor.Create_XOR_Cipher();
            xor.Print_XOR();
        }
    }
}
