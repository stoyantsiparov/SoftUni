int count = int.Parse(Console.ReadLine());
HashSet<string> names = new HashSet<string>();

for (int i = 0; i < count; i++)
{
    string name = Console.ReadLine();
    names.Add(name);            // Добавя име само, което все още го няма
}

foreach (var name in names)
{
    Console.WriteLine(name);
}