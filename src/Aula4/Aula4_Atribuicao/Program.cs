using System;

namespace Aula4_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1; // atribuição única

            Console.WriteLine("int a;");
            Console.WriteLine("a = 1;");
            Console.WriteLine($"int a = {a}");

            int b, c, d;
            Console.WriteLine("int b, c, d;");

            //atribuição encadeada. as Variaveis terão valor =9
            b = c = d = 9;
            Console.WriteLine("b = c = d = 9");

            Console.WriteLine($"int b= {b};");
            Console.WriteLine($"int c= {c};");
            Console.WriteLine($"int d= {d};");
        }
    }
}
