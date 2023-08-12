using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int vowelsCount = GetVowelsCountSentence(sentence);

            Console.WriteLine(vowelsCount);
        }

        static int GetVowelsCountSentence(string sentence)
        {
            int count = 0;

            sentence = MakesAllLettersInTheSentenceSmaller(sentence);
            foreach (char symbol in sentence)
            {
                if (symbol == 'a' ||
                    symbol == 'i' ||
                    symbol == 'e' ||
                    symbol == 'o' ||
                    symbol == 'u' )
                {
                    count++;
                }
            }

            return count;
        }

        private static string MakesAllLettersInTheSentenceSmaller(string sentence)
        {
            sentence = sentence.ToLower();
            return sentence;
        }
    }
}
