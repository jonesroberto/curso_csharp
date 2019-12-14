using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoValorPredefinidos.Execute();
            TipoValorDefinidosUsuarios.Execute();

            Console.WriteLine("Please any key to close application!");
            Console.ReadKey();
        }
    }
}
