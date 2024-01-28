using System;
class Zadanie_4
{
static void Main(string[] args)
{
Console.WriteLine("Введите сумму вклада: ");
double Dengy = Convert.ToDouble(Console.ReadLine());

        if (Dengy < 100)
        {
            Dengy = Dengy + (Dengy * 5 / 100);
        }
        else if (Dengy >= 100 && Dengy <= 200)
        {
            Dengy = Dengy + (Dengy * 7 / 100);
        }
        else
        {
            Dengy =  Dengy + (Dengy * 10 / 100);
        }

        Console.WriteLine($"Сумма вклада с начислением процентов: {Dengy}");
        Console.ReadKey();
    }
}