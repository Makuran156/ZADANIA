using System;


 class Zadanie_5 
{ static void Main(string[] args) 
    { int Number;

    Console.WriteLine("Введите номер операции (1. Сложение, 2. Вычитание, 3. Умножение):");
    Number = Convert.ToInt32(Console.ReadLine());

    switch (Number)
{
    case 1:
    Console.WriteLine("Операция: Сложение");
    break;
    case 2:
    Console.WriteLine("Операция: Вычитание");
    break;
    case 3:
    Console.WriteLine("Операция: Умножение");
    break;
    default:
    Console.WriteLine("Неопределенная операция");
    break;
}

Console.ReadKey();
}
}
