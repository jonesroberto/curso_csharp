using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3_Strings
{
    public static class Strings
    {
        public static void Execute()
        {
            ExecuteString();
            ExecuteStringCompare();
            ExecuteConcat();
            ExecuteInterpolate();
        }

        private static void ExecuteString()
        {
            string myString1 = "Eu sou um string";
            Console.WriteLine($"string myString1 = {myString1};");

            string myString2 = "Caixa d\' água";
            Console.WriteLine($"string myString2 = {myString2};");

            string myString3 = @"Sant""Ana";
            Console.WriteLine($"string myString3 = {myString3};");

            string myString4 = @"Constante string verbatim";
            Console.WriteLine($"string myString4 = {myString4};");

            Console.WriteLine("====================================");
        }

        private static void ExecuteStringCompare()
        {
            string myString = "C#", myString2 = "C#";

            if (myString == myString2)
                Console.WriteLine("Strings iguais");

            Console.WriteLine("====================================");
        }

        private static void ExecuteConcat()
        {
            string myString = "Microsoft ", myString2 = "C#";
            string myString3 = myString + myString2;
            Console.WriteLine(myString3);
        }

        private static void ExecuteInterpolate()
        {
            string myString = "Microsoft ", myString2 = "C#";
            Console.WriteLine($"{myString}{myString2}");

            Console.WriteLine("====================================");
        }
    }
}
