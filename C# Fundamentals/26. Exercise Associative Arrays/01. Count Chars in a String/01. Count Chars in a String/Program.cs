internal class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Dictionary<char, int> charOccurrences = new Dictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
        {
            char character = input[i];

            if (character == ' ')
            {
                continue;
            }

            if (!charOccurrences.ContainsKey(character))                // Проверявам дали ключа е създаден
            {
                charOccurrences.Add(character, 0);
            }

            charOccurrences[character]++;                               // Ако не е, тук го добавям
        }

        foreach (KeyValuePair<char, int> pair in charOccurrences)
        {
            char character = pair.Key;
            int occurrences = pair.Value;

            Console.WriteLine($"{pair.Key} -> {pair.Value}");
            //Console.WriteLine($"{character} -> {occurrences}");

        }
    }
}