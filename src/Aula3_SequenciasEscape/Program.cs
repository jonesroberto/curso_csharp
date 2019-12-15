using System;

namespace Aula3_SequenciasEscape
{
    class Program
    {
        static void Main(string[] args)
        {
            char myCharA = '\a';
            Console.WriteLine($"myCharA {myCharA}");

            char myCharB = '\b';
            Console.WriteLine($"myCharB {myCharB}");

            char myCharF = '\f';
            Console.WriteLine($"myCharF {myCharF}");

            char myCharN = '\n';
            Console.WriteLine($"myCharN {myCharN}");

            char myCharR = '\r';
            Console.WriteLine($"myCharR {myCharR}");

            char myCharT = '\t';
            Console.WriteLine($"myCharT {myCharT}");

            char myCharV = '\v';
            Console.WriteLine($"myCharV {myCharV}");

            char myCharAspas = '\"';
            Console.WriteLine($"myCharAspas {myCharAspas}");

            char myCharApostrofo = '\'';
            Console.WriteLine($"myCharApostrofo {myCharApostrofo}");

            char myCharBarras = '\\';
            Console.WriteLine($"myCharBarras {myCharBarras}");

            char myChar0 = '\0';
            Console.WriteLine($"myChar0 {myChar0}");

            Console.WriteLine("Please any key to close application!");
            Console.ReadKey();
        }
    }
}
