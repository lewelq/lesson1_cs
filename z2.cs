using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число:");
        int number3 = int.Parse(Console.ReadLine());
        int maxNumber = number1;
        if (number2 > maxNumber)
        {
            maxNumber = number2;
        }
        if (number3 > maxNumber)
        {
            maxNumber = number3;
        }
        Console.WriteLine($"Максимальное число: {maxNumber}");
    }
}