SortedSet<string> periodicElements = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] elements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    periodicElements.UnionWith(elements); // Обединявам абсулютно всички хешсетове и изписвам само уникалните такива
}

Console.WriteLine(string.Join(" ", periodicElements));