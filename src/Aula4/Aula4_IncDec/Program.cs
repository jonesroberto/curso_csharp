using System;

namespace Aula4_IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1();
            Exemplo2();
        }

        static void Exemplo1()
        {
            int x = 6;
            int y = 0;
            y = x++;
            Console.WriteLine($"x vale {x}"); //7
            Console.WriteLine($"y vale {y}"); //6
            Console.WriteLine("================================");
        }

        static void Exemplo2()
        {
            int x = 6;
            int y = 0;
            y = ++x;
            Console.WriteLine($"x vale {x}"); //7
            Console.WriteLine($"y vale {y}"); //7
            Console.WriteLine("================================");
        }
    }
}
