using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;

            for (int i = 0; i < n; i++)
            {
                int pourLiters = int.Parse(Console.ReadLine());

                if (capacity + pourLiters > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                else
                {
                    capacity += pourLiters;
                }
            }

            Console.WriteLine(capacity);
        }
    }
}
