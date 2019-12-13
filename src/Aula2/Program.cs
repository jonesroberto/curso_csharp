using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool varBoolean = true;
            Console.WriteLine($"My varBoolean bool :{varBoolean}");

            char varWord = 'C', varSpecial = '#';
            Console.WriteLine($"My varWord char :{varWord} and varSpecial char: {varSpecial}");

            decimal varDecimal = 85.90m;
            Console.WriteLine($"My varDecimal decimal :{varDecimal}");

            int varInteger = 10;
            uint varuInteger = 0;
            Console.WriteLine($"My varInteger int :{varInteger}");
            Console.WriteLine($"My varuInteger uint :{varuInteger}");

            byte varByte = -0;
            sbyte varSByte = 1;
            Console.WriteLine($"My varByte byte :{varByte}");
            Console.WriteLine($"My varSByte sbyte :{varSByte}");

            short varShort = -1;
            ushort varUShort = 1;
            Console.WriteLine($"My varShort short :{varShort}");
            Console.WriteLine($"My varUShort ushort :{varUShort}");

            Console.WriteLine("Please any key to close application!");
            Console.ReadKey();
        }
    }
}
