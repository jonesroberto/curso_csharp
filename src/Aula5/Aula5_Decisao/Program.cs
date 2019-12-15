using System;

namespace Aula5_Decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteIfElse();
            ExecuteSwitch();

            Console.WriteLine("Please any key to close application!");
            Console.ReadKey();
        }

        static void ExecuteIfElse()
        {
            int myInt = 10;

            if (myInt > 5)
            {
                Console.WriteLine($"If {myInt}");
                Console.WriteLine("================================");
            }
            else 
            {
                Console.WriteLine($"Else {myInt}");
                Console.WriteLine("================================");
            }
        }

        static void ExecuteSwitch()
        {
            string myString = "A";

            switch (myString)
            {
                case "A":
                case "a":
                    Console.WriteLine("Abacaxi");
                    Console.WriteLine("================================");
                    break;
                case "B":
                case "b":
                    Console.WriteLine("Banana");
                    Console.WriteLine("================================");
                    break;
                default:
                    Console.WriteLine("??????s");
                    break;
            }
        }
    }
}
