using System;

namespace Aula4_Ternarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -5, y;
            y = x < 0 ? -x : x;

            Console.WriteLine($"y = {y}");
        }
    }
}
