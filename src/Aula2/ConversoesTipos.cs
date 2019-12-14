using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2
{
    public static class ConversoesTipos
    {
        public static void Execute()
        {
            ExecuteImplicita();
            ExecuteExplicita();
        }

        public static void ExecuteImplicita()
        {
            int myInt = 98;
            long myLong = myInt;

            Console.WriteLine($"Valor long: {myLong}");
        }

        public static void ExecuteExplicita()
        {
            int myInt = 98;
            long myLong = (long)myInt;

            Console.WriteLine($"Valor long: {myLong}");
        }
    }
}
