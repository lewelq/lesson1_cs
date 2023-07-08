using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int n2 = 2;

        if(number > 1)
        {
            while(n2 <= number)
            {
                Console.Write(n2 + " ");
                n2 = n2 + 2;
            }
        }
    }
}