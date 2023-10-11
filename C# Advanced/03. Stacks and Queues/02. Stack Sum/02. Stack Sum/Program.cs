List<int> input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Stack<int> stack = new Stack<int>(input);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] arguments = command.Split(' ');

    switch (arguments[0])
    {
        // Добавям елементри в Стека
        case "add":
            int first = int.Parse(arguments[1]);
            int second = int.Parse(arguments[2]);
            stack.Push(first);
            stack.Push(second);
            break;
        // Махам {n} на брой елементи от Стека
        case "remove":
            int n = int.Parse(arguments[1]);
            // Проверявам дали Стека има {n} на брой елементи в Стека -> ако ДА ги махам, ако НЕ (не правя нищо) 
            if (n <= stack.Count)
            {
                for (int i = 0; i < n; i++)
                {
                    stack.Pop();
                }
            }
            break;
    }

    command = Console.ReadLine().ToLower();
}

int sum = 0;
// Обхождам Стека
while (stack.Count > 0)
{
    sum += stack.Pop();
}

Console.WriteLine($"Sum: {sum}");
