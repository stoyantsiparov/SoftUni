using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsTopNumber(int num)
        {
            if (IsDivisibleByEight(num) && HasOddNumber(num))
            {
                return true;
            }

            return false;
        }

        static bool IsDivisibleByEight(int num)
        {
            int sumOfAllNumbers = 0;

            while (num > 0)                             // Този цикъл взима всяка една цифра от числото и ги сумира
            {
                int number = num % 10;                  // Тази операция взима цифрите на числото
                sumOfAllNumbers += number;              // Тази операция сумира цифрите на числото
                num /= 10;                              // Тази операция взима следващото число
            }

            return sumOfAllNumbers % 8 == 0;            // Тази операция проверява дали сумираните цифри на числото се делят на 8
        }

        static bool HasOddNumber(int num)
        {
            while (num > 0)
            {
                int number = num % 10;                  // Взимам числото
                if (number % 2 == 1)                    // Проверявам дали е нечетно
                {
                    return true;
                }

                num /= 10;                              // Взимам следващото число
            }

            return false;
        }
    }
}
