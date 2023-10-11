using System.Xml.Linq;

Action<string[]> print = names =>
    Console.WriteLine(string.Join(Environment.NewLine, names)); // {Environment.NewLine} слага всеки принт на нов ред (/r/n)

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(names);