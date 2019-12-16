using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5_Iteracao
{
    public static class ForEachs
    {
        public static void Execute()
        {
            ExecuteForEach();
        }

        static void ExecuteForEach()
        {
            int[] pares = new int[5];

            for (int i = 0; i < 5; ++i)
            {
                pares[i] = (i * 2) + 2;
            }

            foreach (var item in pares)
            {
                Console.WriteLine($"Número : {item}");
            }
        }
    }
}
