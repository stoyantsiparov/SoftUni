int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    int[] commandInfo = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    if (commandInfo[0] == 1)
    {
        stack.Push(commandInfo[1]);
    }
    else if (commandInfo[0] == 2)
    {
        stack.Pop();
    }
    else if (commandInfo[0] == 3 && stack.Count > 0)
    {
        Console.WriteLine(stack.Max());
    }
    else if (commandInfo[0] == 4 && stack.Count > 0)
    {
        Console.WriteLine(stack.Min());
    }
}

Console.WriteLine(string.Join(", ", stack));