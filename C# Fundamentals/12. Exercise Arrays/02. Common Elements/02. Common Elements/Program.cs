using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();
            // Сравнявам 1вия масив с 2рия - търся еднакви елементи
            for (int j = 0; j < secondArr.Length; j++)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] == secondArr[j])  // Сравнявам елемент по елемент от 1вия индекс 2рия и т.н.
                    {
                        Console.Write($"{secondArr[j]} ");
                    }
                }
            }
        }
    }
}
