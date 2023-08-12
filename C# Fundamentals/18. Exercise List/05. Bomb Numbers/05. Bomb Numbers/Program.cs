using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            list = Explodes(list, bomb);

            Console.WriteLine(Sum(list));
        }

        static int Sum(List<int> list)
        {
            int sum = 0;                                                    // Правя си променлива за сумата на останалите числа от списъка
            foreach (int item in list)                                      // Създавам {foreach} цикъл, който обикаля списъка и събира всички елементи
            {
                sum += item;                                                // Елементите от списъка се събират и записват в променливата за сумата {sum}
            }

            return sum;
        }

        static List<int> Explodes(List<int> list, List<int> bomb)
        {
            int number = bomb[0];                                           // Бомбата ми е на 1вия индекс {0}
            int power = bomb[1];                                            // Силата на бомбата ми е на 2рия индекс {1}

            while (list.Contains(number))                                   // Цикъла се изпълнява, докато числото на 1вия индекс (бомбата) е още в масива
            {
                int index = list.IndexOf(number);                           // Взимам индекса на елемента който ми е подаден от конзолата - бомбата

                int leftIndex = Math.Max(0, index - power);                 // Изчисявам левия индекс на експлоцията -> от индекс {0} до индекса на {бомбата - силата и}
                int rightIndex = Math.Min(list.Count - 1, index + power);   // Изчисявам десния индекс на експлоцията -> от  последния индекс {list.Count - 1} до индекса на {бомбата + силата и}

                int range = rightIndex - leftIndex + 1;                     // Изчислявам обхвата на експлоцията (бомбата + силата и) 
                list.RemoveRange(leftIndex, range);                   // Премахвам елементите в списъка засегнати от експлозията
            }

            return list;
        }
    }
}
