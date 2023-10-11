List<int> items = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int item = int.Parse(Console.ReadLine());

    items.Add(item);
}

List<int> indices = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Swap(indices[0], indices[1], items);

foreach (var item in items)
{
    Console.WriteLine($"{item.GetType()}: {item}");
}

static void Swap<T>(int fisrtIndex, int secondIndex, List<T> items)
{
    T temp = items[fisrtIndex];
    items[fisrtIndex] = items[secondIndex];
    items[secondIndex] = temp;
}