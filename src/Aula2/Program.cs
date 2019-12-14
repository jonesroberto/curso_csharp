using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para executar o Programa");
            Console.WriteLine("1 - TipoValorPredefinidos");
            Console.WriteLine("2 - TipoValorDefinidosUsuarios");
            Console.WriteLine("3 - ConversoesTipos");

            var command = Console.ReadKey();
            Console.WriteLine("");

            switch (command.Key)
            {
                case ConsoleKey.NumPad1:
                TipoValorPredefinidos.Execute();
                    break;
                case ConsoleKey.D1:
                    TipoValorPredefinidos.Execute();
                    break;
                case ConsoleKey.NumPad2:
                    TipoValorDefinidosUsuarios.Execute();
                    break;
                case ConsoleKey.D2:
                    TipoValorDefinidosUsuarios.Execute();
                    break;
                case ConsoleKey.NumPad3:
                    ConversoesTipos.Execute();
                    break;
                case ConsoleKey.D3:
                    ConversoesTipos.Execute();
                    break;
                default:
                    Console.WriteLine(" Digite uma tecla válida!");
                    break;    
            }

            Console.WriteLine("Please any key to close application!");
            Console.ReadKey();
        }
    }
}
