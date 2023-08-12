using System.Text.RegularExpressions;

internal class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"(?<firstWord>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))(?<secondWord>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))";

        List<string> mirrors = new List<string>();                      // Създавам празен списък
        int pairCount = 0;

        foreach (Match match in Regex.Matches(input, pattern))
        {
            string firstWord = match.Groups["firstWord"].Value;
            string secondWord = match.Groups["secondWord"].Value;

            // @gosho@@ohsog@
            if (firstWord[0] == firstWord[firstWord.Length - 1] &&       // Взимам 1вия знак от 1вата дума {firstWord[0]} и го сравнявам с последния {firstWord[firstWord.Length - 1]}
                firstWord[0] == secondWord[0] &&                         // Взимам 1вия знак от 1вата дума {firstWord[0]} и го сравнявам с 1вия знак на 2рата дума {secondWord[0]}
                secondWord[0] == secondWord[secondWord.Length - 1])      // Взимам 1вия знак от 2рата дума {secondWord[0]} и го сравнявам с последния secondWord[secondWord.Length - 1])
            {
                pairCount++;                                             // И ако думите са еднакви увеличавам {pairCount++}

                string mirrored = new string(secondWord.Reverse().ToArray()); // Обръщам 2рата дума наобраотно, за да стане идентична на първата

                if (firstWord == mirrored)                                    // Проверявам дали 1вата дума е еднаква като 2рата
                {
                    string cleanPattern = @"(?:\@|\#)";                       // Създавам {pattern}, който ще премахвам от 2те думи в долните редове
                    string cleanFirstWord = Regex.Replace(@firstWord, cleanPattern, "");        // Премахвам @ и # от първата дума, чрез горния {pattern}
                    string cleanSecondWord = Regex.Replace(@secondWord, cleanPattern, "");      // Премахвам @ и # от втората дума, чрез горния {pattern}

                    mirrors.Add($"{cleanFirstWord} <=> {cleanSecondWord}");                                 // В празния списък добавям вече ЧИСТИТЕ думи (без @ и #)
                }
            }
        }
        // ПРИНТИРАМ
        if (pairCount <= 0)
        {
            Console.WriteLine("No word pairs found!");
        }
        else
        {
            Console.WriteLine($"{pairCount} word pairs found!");
        }

        if (mirrors.Count > 0)
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", mirrors));
        }
        else
        {
            Console.WriteLine("No mirror words!");
        }
    }
}
