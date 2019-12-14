using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2_Enumeradores
{
    public static class Enums
    {
        public static void Execute()
        {
            ExecuteEnumColors();
            ExecuteEnumColorsFor();
        }

        public static void ExecuteEnumColors()
        {
            int blue = (int)Colors.Blue;
            int green = (int)Colors.Green;

            Console.WriteLine($"Color blue value {blue}");
            Console.WriteLine($"Color green value {green}");
        }

        public static void ExecuteEnumColorsFor()
        {
            Colors myColors;

            for (myColors = Colors.Blue; myColors <= Colors.Yellow; myColors++)
            {
                Console.WriteLine($"{myColors} - value {(int)myColors}");
            }
        }
    }
}
