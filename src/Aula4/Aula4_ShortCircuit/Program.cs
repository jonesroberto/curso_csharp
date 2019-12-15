using System;

namespace Aula4_ShortCircuit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 0;

            if (n2 != 0 && (n1 % n2) == 0) //short-circuit
                Console.WriteLine("Operador &&");
            if (n2 != 0 & (n1 % n2) == 0)
                Console.WriteLine("Operador &");
        }
    }
}
