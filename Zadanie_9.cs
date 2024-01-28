using System;

class Zadanie_9
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (int num in arr.Where(x => x % 2 != 0))
        {
            Console.Write(num + " ");
        }

        Console.ReadKey();
    }
}
