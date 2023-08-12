using System;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split();     // Създавам масив, в който се въвеждат данните от конзолата
            int[] numbers = new int[inputArr.Length];           // Създавам масив, който е с дължината на първия

            for (int i = 0; i < inputArr.Length; i++)           // Този for цикъл обикаля дължината на масива {string[] inputArr}
            {
                numbers[i] = int.Parse(inputArr[i]);            // Присвоявам стойностите въведени от конзолата като стрингове от {inputArr[i]} в индексите на {numbers[i]} като числа
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTop = true;                              // Записва по-голямото число по default-на стойност
                for (int j = i + 1; j < numbers.Length; j++)    // Този for цикъл взима първия индекс на {numbers[i] = 0} и следващия индекс {numbers[j] = 1}, с помощта на тази операция {j = i + 1}
                {
                    if (numbers[i] <= numbers[j])               // Това if условие сравнява [i] и [j], с цел да разбере кога дясното число[j] е по-малко от лявото[i], за да не го запише  
                    {
                        isTop = false;                          // Не записва, че числото е по-голямо
                        break;
                    }
                }

                if (isTop)                                      
                {
                    Console.Write($"{numbers[i]} ");        // Изписват се само по-големите числа
                }
            }
        }
    }
}
