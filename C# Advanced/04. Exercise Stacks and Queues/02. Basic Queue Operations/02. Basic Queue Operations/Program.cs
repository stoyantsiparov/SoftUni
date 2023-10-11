int[] values = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int valuesToPush = values[0];
int valuesToPop = values[1];
int lookUpValues = values[2];

Queue<int> stack = new Queue<int>();
// Queue<int> stack = new Queue<int>(input.Take(valuesToPush)); -> Втори начин, от който не ми трябва долния {for} 

for (int i = 0; i < valuesToPush; i++)
{
    stack.Enqueue(input[i]);
}

while (stack.Count > 0 && valuesToPop > 0)
{
    stack.Dequeue();
    valuesToPop--;
}

if (stack.Contains(lookUpValues))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(stack.Min());
}