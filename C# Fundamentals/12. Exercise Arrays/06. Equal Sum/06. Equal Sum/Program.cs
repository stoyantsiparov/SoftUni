using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                index = -1;                                     // Намаля {index-са всеки} път с 1, за да 
                int leftSum = 0;                                // Зануляваме лявата сума, докато не се изравни с дясната или докато не се изпише ("no")
                int rightSum = 0;                               // Зануляваме дясната сума, докато не се изравни с лявата или докато не се изпише ("no")

                for (int j = i - 1; j >= 0; j--)                // Обратен for цикъл, който започва от последния индекс вдясно и ходи наляво с помощта на {j = i - 1}
                {
                    leftSum += numbers[j];                      // Изчислява сумата от лявата част на израза
                }

                for (int j = i + 1; j < numbers.Length; j++)    // Този for цикъл, започва от първия индекс вляво и ходи надясно с помощта на {j = i + 1}
                {                   
                    rightSum += numbers[j];                     // Изчислява сумата от дясната част на израза
                }

                if (leftSum == rightSum)                        // Сравнява сумите в лявата и дясната част на израза
                {
                    index = i;                                  // Ако са еднакви сумите в дадения {index}, то {index = i} и задачата приключва
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
