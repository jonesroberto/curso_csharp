using System;

namespace Aula5_Desvio
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteBreak();
            ExecuteContinue();
            ExecuteGoto();
            ExecuteReturn();

            Console.WriteLine("Please any key to close application!");
            Console.ReadKey();
        }

        static void ExecuteBreak()
        {
            int myInt;

            for (myInt = -5; myInt <= 5; ++myInt)
            {
                if (myInt > 0)
                    break;
                Console.Write($"{myInt} \n");
            }

            Console.WriteLine("================================");
        }

        static void ExecuteContinue()
        {
            int k, numint, somat = 0;
            string numStr;

            for (k = 1; k < 5; ++k)
            {
                Console.WriteLine("Digite um número inteiro: ");
                numStr = Console.ReadLine();
                numint = Int32.Parse(numStr);

                if (numint < 0)
                    continue;

                somat = somat + numint;
            }

            Console.WriteLine($"Somatório: {somat}"); // 15
            Console.WriteLine("================================");
        }

        static void ExecuteGoto()
        {
            int somat = 0, k = 0;

            Retorno:
            k += 1;
            if (k < 6)
            {
                Console.WriteLine($"k: {k}");
                somat = somat + k;
                goto Retorno;
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine($"Somatório {somat}"); // 15
            }

            Console.WriteLine("================================");
        }

        static void ExecuteReturn()
        {
            int result;
            int CalcQuad(int num)
            {
                return num * num;
            }

            result = CalcQuad(3);
            Console.WriteLine($"Quadrado de 3 {result}"); // 9
            Console.WriteLine("================================");
        }
    }
}
