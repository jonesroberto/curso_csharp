using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5_Iteracao
{
    static class Whiles
    {
        public static void Execute()
        {
            ExecuteDoWhile();
        }

        private static void ExecuteDoWhile()
        {
            string valor, senha = "c#";

            do
            {
                Console.WriteLine("Digite a senha: ");
                valor = Console.ReadLine();
            }
            while (senha != valor);

            Console.WriteLine("================================");
        }
    }
}
