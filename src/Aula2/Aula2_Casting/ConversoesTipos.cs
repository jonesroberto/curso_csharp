using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2_Parte4
{
    public static class ConversoesTipos
    {
        public static void Execute()
        {
            ExecuteImplicita();
            ExecuteExplicita();
            ExecuteExplicita2();
        }

        public static void ExecuteImplicita()
        {
            int myInt = 98;
            long myLong = myInt;

            Console.WriteLine("long myLong = myInt;");
            Console.WriteLine($"Valor long: {myLong}");
        }

        public static void ExecuteExplicita()
        {
            int myInt = 85000;
            short myLong = (short)myInt;

            Console.WriteLine($"tentativa de converter 85000 : converteu {myLong}");
            Console.WriteLine("short myLong = (short)myInt;");
            Console.WriteLine($"Valor long: {myLong}");
        }

        public static void ExecuteExplicita2()
        {
            int myInt = 85;
            short myLong = (short)myInt;

            Console.WriteLine("short myLong = (short)myInt;");
            Console.WriteLine($"Valor long: {myLong}");
        }
    }
}
