using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(" ");
                switch (arguments[0])
                {
                    case "swap":
                        list = SwapIndexPosition(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;
                    case "multiply":
                        list = MultiplyTwoElements(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;
                    case "decrease":
                        list = DecreaseAllElementByOne(list);
                        break;
                }

            }

            Console.WriteLine(string.Join(", ", list));
        }

        static List<int> DecreaseAllElementByOne(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] -= 1;
            }
            return list;
        }

        static List<int> MultiplyTwoElements(List<int> list, int multiplyer, int multiplycator)
        {
            int multiplySum = list[multiplyer] * list[multiplycator];
            list[multiplyer] = multiplySum;
            return list;
        }

        static List<int> SwapIndexPosition(List<int> list, int index1, int index2)
        {
            int swapedIndexes = list[index1];
            list[index1] = list[index2];
            list[index2] = swapedIndexes;
            return list;
        }
    }
}
