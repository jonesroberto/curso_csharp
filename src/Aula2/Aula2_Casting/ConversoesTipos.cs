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

            Console.WriteLine($"int myInt = {myInt};");
            Console.WriteLine($"long myLong = = {myLong};");
            Console.WriteLine($"Result : {myLong}");
            Console.WriteLine("====================================");
        }

        public static void ExecuteExplicita()
        {
            int myInt = 85000;
            short myLong = (short)myInt;

            Console.WriteLine($"tentativa de converter 85000 : converteu {myLong}");
            Console.WriteLine($"int myInt = {myInt};");
            Console.WriteLine("short myLong = (short)myInt;");
            Console.WriteLine($"Result : {myLong}");
            Console.WriteLine("====================================");
        }

        public static void ExecuteExplicita2()
        {
            int myInt = 85;
            short myLong = (short)myInt;

            Console.WriteLine($"int myInt = {myInt};");
            Console.WriteLine($"short myLong = (short)myInt");
            Console.WriteLine($"Result : {myLong}");
            Console.WriteLine("====================================");
        }
    }
}
