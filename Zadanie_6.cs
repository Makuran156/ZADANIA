using System;

class Zadanie_6 
{ static void Main(string[] args) 
    { Console.WriteLine("Введите сумму вклада:"); 
        var Dengy = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Введите количество месяцев:");
var months = Convert.ToInt32(Console.ReadLine());

var FDengy = 0m;

for (int i = 0; i < months; i++)
{
FDengy += (Dengy * 0.07m);
}

        FDengy += Dengy;

Console.WriteLine($"Конечная сумма вклада составляет: { FDengy}");

Console.ReadKey();
}
}