using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int i = start;

            for (; i < end; i++) // For цикъла представялва ASCII Table --> Числата са = на букви или знаци (стандарт в програмирането)
            {
                Console.Write($"{(char)i} "); // Според ASCII Table {А = 65}
            }

            Console.WriteLine((char)i);
        }
    }
}
