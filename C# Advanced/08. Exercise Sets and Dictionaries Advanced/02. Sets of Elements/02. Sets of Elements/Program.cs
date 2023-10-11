HashSet<int> firstSet = new();
HashSet<int> secondSet = new();

int[] counts = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


for (int i = 0; i < counts[0]; i++)
{
    int firstNumber = int.Parse(Console.ReadLine());
    firstSet.Add(firstNumber);
}

for (int i = 0; i < counts[1]; i++)
{
    int secondNumber = int.Parse(Console.ReadLine());
    secondSet.Add(secondNumber);
}

firstSet.IntersectWith(secondSet);                  // Двата хешсета се взимат заедно и се изписва САМО общите елементи между двата

Console.WriteLine(string.Join(" ", firstSet));