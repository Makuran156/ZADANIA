using System;

    class Zadanie_10
    {
        static void Main(string[] args)
        {
            string[] array = { "�����", "�����", "���������" };

            Console.Write("������� ������: ");
            string input = Console.ReadLine();

            if (array.Contains(input))
            {
                Console.WriteLine("������ �������!");
            }
            else
            {
                Console.WriteLine("������ �� �������!");
            }

            Console.ReadKey();
        }
    }