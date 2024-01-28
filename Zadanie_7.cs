using System;

class Zadanie_7
{
    static void Main()
    {
        for (int x = 1; x <= 9; x++)
        {
            Console.Write($"*{x}* |");
            for (int y = 1; y <= 9; y++)
            {
                Console.Write($"{x} * {y} | ");
            }
            Console.WriteLine();
        }
    }
}