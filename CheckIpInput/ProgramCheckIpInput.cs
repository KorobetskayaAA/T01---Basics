using System;

namespace CheckIpInput
{
    class ProgramCheckIpInput
    {
        static void Main(string[] args)
        {
            bool checkByte0 = byte.TryParse(Console.ReadLine(), out _);
            bool checkByte1 = byte.TryParse(Console.ReadLine(), out _);
            bool checkByte2 = byte.TryParse(Console.ReadLine(), out _);
            bool checkByte3 = byte.TryParse(Console.ReadLine(), out _);
            Console.WriteLine(checkByte0);
            Console.WriteLine(checkByte1);
            Console.WriteLine(checkByte2);
            Console.WriteLine(checkByte3);
        }
    }
}
