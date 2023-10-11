List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .OrderByDescending(x => x) // Подреждам списъка от най-голяма към най-малко
    .Take(3)                   // Взимам само 3 числа (най-големите)
    .ToList();

Console.WriteLine(string.Join(" ", numbers));