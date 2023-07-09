//Задание 1
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трёхзначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string stringNumber = Convert.ToString(num);
        Console.WriteLine("вторая цифра этого числа: "+stringNumber[1]);
    }
}
//Задание 2
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string numstr = Convert.ToString(num);
        if (numstr.Length > 2)
        {
            Console.WriteLine("третья цифра: " + numstr[2]);
        }
        else 
        {
            Console.WriteLine("третьей цифры нет");
        }
    }
}
//Задание 3
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер дня недели: ");
        int day = int.Parse(Console.ReadLine());
        if (day == 6 || day == 7)
        {
            Console.WriteLine("День является выходным");
        }
        else if (day > 7 || day < 1)
        {
            Console.WriteLine("Неверный ввод!");
        }
        else
        {
            Console.WriteLine("День не является выходным");
        }
    }
}