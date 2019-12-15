using System;

namespace Aula4_Logicos_Bool_Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1();
            Exemplo2();
            Exemplo3();
            Exemplo4();
            Exemplo5();
        }

        static void Exemplo1()
        {
            Console.WriteLine("~");
            uint myUint2, myUint = 1;

            myUint2 = ~myUint;
            Console.WriteLine($"myUint2 : {myUint2}"); // 4294967294
            Console.WriteLine("================================");
        }

        static void Exemplo2()
        {
            Console.WriteLine("|");
            uint myUint = 51, myUint2 = 89, myUint3;
            myUint3 = myUint | myUint2;
            
            Console.WriteLine($"myUint3 : {myUint3}"); // 123
            Console.WriteLine("================================");
        }

        static void Exemplo3()
        {
            Console.WriteLine("^");
            uint myUint = 51, myUint2 = 89, myUint3;
            myUint3 = myUint ^ myUint2;
            Console.WriteLine($"myUint3: {myUint3}"); // 106
            Console.WriteLine("================================");
        }

        static void Exemplo4()
        {
            Console.WriteLine("&");
            uint myUint = 51, myUint2 = 89, myUint3;
            myUint3 = myUint & myUint2;
            Console.WriteLine($"myUint3: {myUint3}"); // 17
            Console.WriteLine("================================");
        }

        static void Exemplo41()
        {
            Console.WriteLine("& 2");
            bool x = true; bool y = false;

            Console.WriteLine($"{x & y}"); // False
            Console.WriteLine("================================");
        }

        static void Exemplo5()
        {
            Console.WriteLine("!");
            bool myBool = !(7 > 9);
            Console.WriteLine($"myBool: {myBool}"); // True
            Console.WriteLine("================================");
        }
    }
}
