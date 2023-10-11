using System.Text;

namespace EvenLines
{
    using System;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new();

            using StreamReader streamReader = new(inputFilePath);

            string line = string.Empty;
            int count = 0;

            while (line != null)
            {
                line = streamReader.ReadLine();

                if (count % 2 == 0)
                {
                    string replacedSymbols = ReplacedSymbols(line);
                    string reverseWords = ReverseWords(replacedSymbols);
                    sb.AppendLine(reverseWords);
                }

                count++;
            }

            return sb.ToString().TrimEnd();
        }

        private static string ReplacedSymbols(string? line)
        {
            StringBuilder sb = new(line);

            char[] symbolsToReplace = {'-',',','.','!','?'};

            foreach (char symbol in symbolsToReplace)
            {
                sb = sb.Replace(symbol, '@');
            }

            return sb.ToString();
        }
        private static string ReverseWords(string words)
        {
            string[] reverseWords = words
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            return string.Join(" ", reverseWords);
        }
    }
}