using System;

class Zadanie_3
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        try
        {
            int number = int.Parse(input);
            if (number == 5 || number == 10)
            {
                Console.WriteLine("Число равно 5 или 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели неправильное число или текст");
        }
    }
}