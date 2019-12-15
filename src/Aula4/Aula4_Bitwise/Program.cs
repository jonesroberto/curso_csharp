using System;

namespace Aula4_Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            uint valor = 12;
            valor = valor << 1;
            Console.WriteLine($"valor: {valor}"); // 24

            uint valorEsquerda = 12;
            valorEsquerda = valorEsquerda >> 1;
            Console.WriteLine($"valor: {valorEsquerda}"); // 6
        }
    }
}
