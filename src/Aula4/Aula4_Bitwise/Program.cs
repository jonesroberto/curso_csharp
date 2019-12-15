using System;

namespace Aula4_Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            uint valorDireita = 12;
            valorDireita = valorDireita << 1;
            Console.WriteLine($"valorDireita: {valorDireita}"); // 24
            Console.WriteLine("================================");

            uint valorEsquerda = 12;
            valorEsquerda = valorEsquerda >> 1;
            Console.WriteLine($"valor: {valorEsquerda}"); // 6
            Console.WriteLine("================================");
        }
    }
}
