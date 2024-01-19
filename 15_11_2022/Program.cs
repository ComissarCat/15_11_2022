using System;

internal class Program
{
    static void Task_1(int a = 1, int b = 9)
    {
        if (a > b) (a, b) = (b, a);
        for (int i = a; i <= b; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
    static void Task_2(int number = 123)
    {
        int reverse_number = 0;
        while (number > 0)
        {
            reverse_number *= 10;
            reverse_number += number % 10;
            number /= 10;
        }
        Console.WriteLine(reverse_number);
    }
    static void Main()
    {
        Task_1();
        Task_2();
    }
}