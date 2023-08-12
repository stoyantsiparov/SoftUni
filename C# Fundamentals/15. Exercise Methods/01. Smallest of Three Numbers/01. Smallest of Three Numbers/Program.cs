using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());

            FindTheSmallestNumberFromThreeInregers(numbers);

        }

        static void FindTheSmallestNumberFromThreeInregers(int[] numbers)
        {
            int min = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                min = numbers.Min();                    // От свойствата на {using System.Linq;}, така се намира най-малката стойност в масив
            }

            Console.WriteLine(min);
        }
    }
}
