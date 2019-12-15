using System;

namespace Aula4_Aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 10;
            decimal b = 20;

            Console.WriteLine($"decimal a = {a};");
            Console.WriteLine($"decimal b = {b};");
            Console.WriteLine("================================");

            decimal multiplicacao = a * b;
            Console.WriteLine("decimal multiplicacao = a * b;");
            Console.WriteLine($"Resultado :{multiplicacao}");
            Console.WriteLine("================================");

            decimal divisao = a / b;
            Console.WriteLine("decimal divisao = a / b;");
            Console.WriteLine($"Resultado :{divisao}");
            Console.WriteLine("================================");

            decimal restoDivisao = a % b;
            Console.WriteLine("decimal restoDivisao = a % b;");
            Console.WriteLine($"Resultado :{restoDivisao}");
            Console.WriteLine("================================");

            decimal soma = a + b;
            Console.WriteLine("decimal soma = a + b;");
            Console.WriteLine($"Resultado :{soma}");
            Console.WriteLine("================================");

            decimal subtracao = a - b;
            Console.WriteLine("decimal subtracao = a - b;");
            Console.WriteLine($"Resultado :{subtracao}");
            Console.WriteLine("================================");
        }
    }
}
