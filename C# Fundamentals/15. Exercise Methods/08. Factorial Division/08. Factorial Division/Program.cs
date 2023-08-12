using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstlong = long.Parse(Console.ReadLine());
            long secondlong = long.Parse(Console.ReadLine());
            double result = Factorial(firstlong) / Factorial(secondlong);
            Console.WriteLine($"{result:F2}");
        }

        static double Factorial(long number)
        {
            double result = number;                              // Запазвам даденото ми число

            for (long i = number - 1; i >= 1; i--)               // Започвам от {i = number - 1} и го карам до {i >= 1}, за да взема числата за факториела (от началното число-1 до единица)
            {
                result *= i;
            }

            return result;
        }
    }
}