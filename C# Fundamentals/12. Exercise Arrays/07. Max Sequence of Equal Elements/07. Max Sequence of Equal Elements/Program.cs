using System;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split();

            int bestCount = 0;
            string bestCountSequence = "";

            // Обратен FOR цикъл, ако търсим най-дясната част, а не лявата
            //for (int i = sequence.Length - 1; i >= 0; i--)
            //{
            //    int count = 0;
            //    for (int j = i; j >= 0; j--) {}

            for (int i = 0; i < sequence.Length; i++)
            {
                int count = 0;
                for (int j = i; j < sequence.Length; j++)
                {
                    if (sequence[i] == sequence[j])
                    {
                        count++;
                        if (bestCount < count)
                        {
                            bestCount = count;
                            bestCountSequence = sequence[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{bestCountSequence} ");
            }
        }
    }
}