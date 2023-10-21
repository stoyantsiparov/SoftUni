Queue<int> textiles = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Stack<int> medicaments = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int patches = 0;
int bandages = 0;
int medKit = 0;

while (textiles.Any() && medicaments.Any())
{
    int currentTextile = textiles.Peek();
    int currentMedicament = medicaments.Peek();

    int item = currentTextile + currentMedicament;

    if (item == 30)
    {
        patches++;
        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (item == 40)
    {
        bandages++;
        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (item == 100)
    {
        medKit++;
        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (item > 100)
    {
        medKit++;
        textiles.Dequeue();
        medicaments.Pop();

        int remaining = medicaments.Pop();
        remaining += item - 100;
        medicaments.Push(remaining);
    }
    else
    {
        textiles.Dequeue();
        medicaments.Pop();
        medicaments.Push(currentMedicament + 10);
    }
}

if (!textiles.Any() && medicaments.Any())
{
    Console.WriteLine("Textiles are empty.");
}

if (!medicaments.Any() && textiles.Any())
{
    Console.WriteLine("Medicaments are empty.");
}

if (!textiles.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}

Dictionary<string, int> items = new()
{
    {"MedKit", medKit},
    {"Bandage", bandages},
    {"Patch", patches}
};

foreach (var kvp in items.OrderByDescending(i => i.Value).ThenBy(x => x.Key))
{
    if (kvp.Value == 0)
    {
        continue;
    }

    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
}

if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}
if (textiles.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}