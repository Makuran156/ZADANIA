using System;


    class Zadanie_8
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num1 > 10 || num1 < 0 || num2 > 10 || num2 < 0)
                {
                    Console.WriteLine("Введенные числа недопустимые");
                }
                else
                {
                    double result = num1 * num2;
                    Console.WriteLine($"Произведение: {result}");
                    break;
                }
            }
        }
    }
