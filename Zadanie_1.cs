class Zadanie_1
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine(num1 + " больше " + num2);
        }
        else if (num1 < num2)
        {
            Console.WriteLine(num1 + " Меньше " + num2);
        }
        else
        {
            Console.WriteLine(num1 + " Равно " + num2);
        }
    }
}