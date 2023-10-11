SortedDictionary<char, int> charsCounts = new();

string input = Console.ReadLine();

foreach (char c in input)
{
    if (!charsCounts.ContainsKey(c))
    {
        charsCounts.Add(c, 0);
    }

    charsCounts[c]++;
}

foreach (var charsCount in charsCounts)
{
    Console.WriteLine($"{charsCount.Key}: {charsCount.Value} time/s");
}