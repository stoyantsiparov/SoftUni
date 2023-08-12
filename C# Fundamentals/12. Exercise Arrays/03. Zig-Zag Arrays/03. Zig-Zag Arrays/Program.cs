using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool shouldTakeSecond = false;
            int value = int.Parse(Console.ReadLine());
            int[] firstArr = new int[value];
            int[] secondArr = new int[value];


            for (int i = 0; i < value; i++)
            {

                int[] values = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (shouldTakeSecond)
                {
                    secondArr[i] = values[1];
                    firstArr[i] = values[0];
                }
                else
                {
                    secondArr[i] = values[0];
                    firstArr[i] = values[1];
                }

                shouldTakeSecond = !shouldTakeSecond;
                
            }

            Console.WriteLine(string.Join(" ", secondArr));
            Console.WriteLine(string.Join(" ", firstArr));
        }
    }
}
