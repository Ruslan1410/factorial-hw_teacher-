using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.Write("Введите число для вычисления факториала: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 0)
        {
            long factorial = CalculateFactorial(number);

            Console.WriteLine($"Факториал числа {number} равен: {factorial}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите неотрицательное целое число.");
        }
    }

    // Метод для вычисления факториала числа
    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        long result = 1;

        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}

       