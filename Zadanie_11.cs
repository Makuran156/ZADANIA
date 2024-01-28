using System;

class Zadanie_11
{
static void Main(string[] args)
{
int[] numbers = { 1, 2, 3, 4, 5 };

        int sum = numbers.Sum();

        double mean = numbers.Average();

        Console.WriteLine("Сумма элементов массива: " + sum);
        Console.WriteLine("Среднее арифметическое: " + mean);

        Console.ReadKey();
    }
}