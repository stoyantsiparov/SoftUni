Action<string, string[]> printNamesWithAddedTitle = (title, names) =>
{
    foreach (string name in names)
    {
        Console.WriteLine($"{title} {name}");
    }
};

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

printNamesWithAddedTitle("Sir", names);