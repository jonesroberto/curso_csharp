using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    public class Escopo
    {
        void Execute()
        {
            int varA; // no escopo do metodo Execute()
            varA = 20;

            Console.Clear();

            if (varA == 20)
            { 
                int varB = 30; // somente no escopo do "if"
                Console.WriteLine($"varA :{varA}"); //20
                Console.WriteLine($"varB: {varB}"); //30
            }

            //varB = 40; //daria erro por estar fora do escopo
        }
    }
}
