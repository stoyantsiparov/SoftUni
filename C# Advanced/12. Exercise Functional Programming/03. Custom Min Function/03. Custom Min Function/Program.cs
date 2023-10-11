using System.Globalization;

Func<HashSet<int>, int> min = numbers =>
{
    return numbers.Min();
};

    HashSet<int> numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

Console.WriteLine(min(numbers));