using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)                // Обикалям for цикъла, като започвам от първия индекс  {i = 0}
            {
                for (int j = i + 1; j < numbers.Length; j++)        // Обикалям for цикъла, като започвам от първия индекс + 1 {j = i + 1}
                {
                    if (numbers[i] + numbers[j] == sum)             // Проверявам дали сбора на двете числа дава търсената сума
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}