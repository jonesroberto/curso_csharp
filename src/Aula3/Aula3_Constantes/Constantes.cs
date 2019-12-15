using System;

namespace Aula3_Constantes
{
    public static class Constantes
    {
        public static void Execute()
        {
            ExecuteConst();
            ExecuteConstHexa();
            ExecuteConstSimbolic();
        }

        private static void ExecuteConst()
        {
            long myConstLong = 2000L;

            Console.WriteLine($"long myConstLong = {myConstLong};"); // constante long

            float myConstFloat = 1900.0F;
            Console.WriteLine($"float myConstFloat = {myConstFloat};"); // constante float
        }

        private static void ExecuteConstHexa()
        {
            int myConstInt = 0xF; // equivalente ao decimal 15
            Console.WriteLine($"int myConstInt = {myConstInt};");
        }

        private static void ExecuteConstSimbolic()
        {
            const double tax = 5.5;
            Console.WriteLine($"const double tax= {tax};");

            const int limit = 10;
            Console.WriteLine($"const int limit ={limit};");

            int[] values = new int[limit];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = i;
                Console.WriteLine($"my values : {values[i]}" );
            }
        }
    }
}
