using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = Sum(first, second);
            result = Substract(result, third);

            Console.WriteLine(result);
        }

        private static int Substract(int result, int third)
        {
            return result - third;
        }

        static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
