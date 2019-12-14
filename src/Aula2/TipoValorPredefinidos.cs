using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2
{
    public static class TipoValorPredefinidos
    {
        public static void Execute()
        {
            ExecuteBoolean();
            ExecuteChar();
            ExecuteDecimal();
            ExecuteInteger();
            ExecuteByte();
            ExecuteShort();
            ExecuteFloat();
            ExecuteDouble();
        }

        private static void ExecuteBoolean()
        {
            bool varBoolean = true;
            Console.WriteLine($"My varBoolean bool :{varBoolean}");
        }

        private static void ExecuteChar()
        {
            char varWord = 'C', varSpecial = '#';
            Console.WriteLine($"My varWord char :{varWord} and varSpecial char: {varSpecial}");
        }

        private static void ExecuteDecimal()
        {
            decimal varDecimal = 85.90m;
            Console.WriteLine($"My varDecimal decimal :{varDecimal}");
        }

        private static void ExecuteInteger()
        {
            int varInteger = 10;
            uint varuInteger = 0;
            Console.WriteLine($"My varInteger int :{varInteger}");
            Console.WriteLine($"My varuInteger uint :{varuInteger}");
        }

        private static void ExecuteByte()
        {
            byte varByte = -0;
            sbyte varSByte = 1;
            Console.WriteLine($"My varByte byte :{varByte}");
            Console.WriteLine($"My varSByte sbyte :{varSByte}");
        }

        private static void ExecuteShort()
        {
            short varShort = -1;
            ushort varUShort = 1;
            Console.WriteLine($"My varShort short :{varShort}");
            Console.WriteLine($"My varUShort ushort :{varUShort}");
        }

        private static void ExecuteFloat()
        { 
        
        }

        private static void ExecuteDouble()
        { 
        
        }
    }
}
