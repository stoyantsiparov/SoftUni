using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int[] waggons = new int[wagonsCount];

            for (int i = 0; i < waggons.Length; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                waggons[i] = passengers;
            }

            Console.WriteLine(string.Join(" ", waggons)); // Принтира резултата с 1 space между числата
            Console.WriteLine(waggons.Sum()); // Събира ми числата в масива с помощта на {using System.Linq;}

            // Втори начин за решаване на сумата
            //int total = 0;
            //for (int i = 0; i < waggons.Length; i++)
            //{
            //    total += waggons[i];
            //}
            //
            //Console.WriteLine(total);
        }
    }
}
