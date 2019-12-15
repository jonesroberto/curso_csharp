using System;

namespace Aula5_BlocoComandos
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 50;
            
            {
                int myInt2 = 100;
                Console.WriteLine($"myInt no bloco {myInt}");
                Console.WriteLine($"myInt2 no bloco {myInt2}");
            }

            Console.WriteLine($"myInt fora do bloco {myInt}");
            //Console.WriteLine($"myInt2 não funciona fora do bloco : {myInt2}");
        }
    }
}
