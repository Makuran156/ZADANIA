using System;

    class Zadanie_10
    {
        static void Main(string[] args)
        {
            string[] array = { "Кварц", "Смола", "Сомородок" };

            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            if (array.Contains(input))
            {
                Console.WriteLine("Строка найдена!");
            }
            else
            {
                Console.WriteLine("Строка не найдена!");
            }

            Console.ReadKey();
        }
    }