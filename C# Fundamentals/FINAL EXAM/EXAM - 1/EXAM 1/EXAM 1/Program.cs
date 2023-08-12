internal class Program
{
    public static void Main(string[] args)
    {
        string initialString = Console.ReadLine();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "End")
                break;

            string[] commandParts = command.Split();
            string action = commandParts[0];

            switch (action)
            {
                case "Translate":
                    initialString = Translate(initialString, commandParts[1][0], commandParts[2][0]);
                    break;
                case "Includes":
                    Includes(initialString, commandParts[1]);
                    break;
                case "Start":
                    Start(initialString, commandParts[1]);
                    break;
                case "Lowercase":
                    initialString = Lowercase(initialString);
                    break;
                case "FindIndex":
                    FindIndex(initialString, commandParts[1][0]);
                    break;
                case "Remove":
                    initialString = Remove(initialString, int.Parse(commandParts[1]), int.Parse(commandParts[2]));
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }

    static string Translate(string str, char target, char replacement)
    {
        string newString = str.Replace(target, replacement);
        Console.WriteLine(newString);
        return newString;
    }

    static void Includes(string str, string substring)
    {
        bool result = str.Contains(substring);
        Console.WriteLine(result);
    }

    static void Start(string str, string substring)
    {
        bool result = str.StartsWith(substring);
        Console.WriteLine(result);
    }

    static string Lowercase(string str)
    {
        string newString = str.ToLower();
        Console.WriteLine(newString);
        return newString;
    }

    static void FindIndex(string str, char target)
    {
        int index = str.LastIndexOf(target);
        Console.WriteLine(index);
    }

    static string Remove(string str, int startIndex, int count)
    {
        string newString = str.Remove(startIndex, count);
        Console.WriteLine(newString);
        return newString;
    }
}
