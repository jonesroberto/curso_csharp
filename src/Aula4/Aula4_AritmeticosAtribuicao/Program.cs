using System;

namespace Aula4_AritmeticosAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 10;

            Console.WriteLine($"decimal a = {a};");
            Console.WriteLine("================================");

            decimal multiplicacao = 10;
            multiplicacao *= a;
            Console.WriteLine("decimal multiplicacao = 10;");
            Console.WriteLine("multiplicacao *= a;");
            Console.WriteLine($"Resultado :{multiplicacao}");
            Console.WriteLine("================================");

            decimal divisao = 10;
            divisao /= a;
            Console.WriteLine("decimal divisao = 10;");
            Console.WriteLine("divisao /= a;");
            Console.WriteLine($"Resultado :{divisao}");
            Console.WriteLine("================================");

            decimal restoDivisao = 10;
            restoDivisao %= a;
            Console.WriteLine("decimal restoDivisao = 10;");
            Console.WriteLine("restoDivisao %= a;");
            Console.WriteLine($"Resultado :{restoDivisao}");
            Console.WriteLine("================================");

            decimal soma = 20;
            soma += a;
            Console.WriteLine("decimal soma = 20;");
            Console.WriteLine("soma += a;");
            Console.WriteLine($"Resultado :{soma}");
            Console.WriteLine("================================");

            decimal subtracao = 10;
            subtracao -= a;
            Console.WriteLine("decimal subtracao = 10;");
            Console.WriteLine("subtracao -= a;");
            Console.WriteLine($"Resultado :{subtracao}");
            Console.WriteLine("================================");
        }
    }
}
