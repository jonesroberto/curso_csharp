using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5_Iteracao
{
    static class Fors
    {
        public static void Execute()
        {
            ExecuteFor1();
            ExecuteFor2();
            ExecuteFor3();
            ExecuteFor4();
            ExecuteFor5();
            ExecuteFor6();
        }

        static void ExecuteFor1()
        {
            int result = 0, i;
            Console.WriteLine($"i =");

            for (i = 1; i < 6; ++i)
            {
                Console.Write($"{i} ");
                //result = result + i;
                result += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Resultado da soma {result}");
            Console.WriteLine("================================");
        }

        static void ExecuteFor11()
        {
            int result = 0;
            Console.WriteLine($"i =");

            for (int i = 1; i < 6; ++i)
            {
                Console.Write($"{i} ");
                //result = result + i;
                result += i;
            }

            //Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine($"Resultado da soma {result}");
            Console.WriteLine("================================");
        }

        static void ExecuteFor2()
        {
            int i, j;

            for (i = 1, j = 5; j > 0; ++i,--j)
            {
                Console.WriteLine($"i = {i} - j = {j}");
            }

            Console.WriteLine("================================");
        }

        static void ExecuteFor3()
        {
            int i = 1;
            Console.Write("i =");

            for (; i < 6; ++i)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine("================================");
        }

        static void ExecuteFor4()
        {
            Console.Write("i =");

            for (int i = 1; i < 6;)
            {
                Console.Write($"{i} ");
                ++i;
            }

            Console.WriteLine();
            Console.WriteLine("================================");
        }

        static void ExecuteFor5()
        {
            int result = 0, i;

            for (i = 1; i < 6; result += i, ++i)
                Console.WriteLine($"Resultado da soma {result}");

            Console.WriteLine();
            Console.WriteLine("================================");
        }

        static void ExecuteFor6()
        {
            int i, j;

            for (i = 1; i < 4; ++i)
            {
                Console.WriteLine($"i : {i}");
                Console.WriteLine("Externo");
                for (j = 1; j < 4; ++j)
                {
                    Console.WriteLine($"j : {j}");
                    Console.WriteLine("Interno");
                }
            }

            Console.WriteLine();
            Console.WriteLine("================================");
        }
    }
}
