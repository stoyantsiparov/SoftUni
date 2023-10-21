
Stack<int> fuel = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Queue<int> consumptionIndex = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> amountOfNeededFuel = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

List<string> altitudeList = new List<string>();

int altitude = 1;

while (fuel.Any())
{
    int currentFuel = fuel.Peek();
    int currentConsumption = consumptionIndex.Peek();
    int result;

    if ((result = currentFuel - currentConsumption) >= amountOfNeededFuel.Peek())
    {
        Console.WriteLine($"John has reached: Altitude {altitude}");
        altitudeList.Add($"Altitude {altitude}");
        fuel.Pop();
        consumptionIndex.Dequeue();
        amountOfNeededFuel.Dequeue();
    }
    else
    {
        Console.WriteLine($"John did not reach: Altitude {altitude}");
        break;
    }

    altitude++;
}

PrintResult(fuel, altitudeList, amountOfNeededFuel);
void PrintResult(Stack<int> stack, List<string> list, Queue<int> queue)
{
    if (stack.Any() && list.Count == 0)
    {
        Console.WriteLine("John failed to reach the top.");
        Console.WriteLine("John didn't reach any altitude.");
    }
    else if (stack.Any() && list.Count > 0)
    {
        Console.WriteLine("John failed to reach the top.");
        Console.WriteLine($"Reached altitudes: {string.Join(", ", list)}");
    }

    if (!queue.Any())
    {
        Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
    }
}