using System.Text;

internal class Program
{
    public static void Main(string[] args)
    {
        string rowPassword = Console.ReadLine();
        StringBuilder password = new StringBuilder(rowPassword);

        string input;
        while ((input = Console.ReadLine()) != "Done")
        {
            string[] arguments;
            arguments = input.Split();
            switch (arguments[0])
            {
                case "TakeOdd":
                    password = TakeOdd(password);
                    break;
                case "Cut":
                    int startIndex = int.Parse(arguments[1]);
                    int length = int.Parse(arguments[2]);

                    password = Cut(password, startIndex, length);
                    break;
                case "Substitute":
                    string substring = arguments[1];
                    string substitute = arguments[2];

                    password = Substitute(password, substring, substitute);
                    break;
            }
        }

        Console.WriteLine($"Your password is: {password}");
    }

    private static StringBuilder Substitute(StringBuilder password, string oldSymbols, string newSymbols)
    {
        string sbToStr = password.ToString();                                                   // {StringBuilder-a} го превърщам в {string}, за да мога да ползвам {.Contains}

        if (sbToStr.Contains(oldSymbols))
        {
            password = password.Replace(oldSymbols, newSymbols);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }

        return password;
    }

    private static StringBuilder Cut(StringBuilder password, int startIndex, int length)        // Премахвам част от {input-a} по даден {index} с дадена дължина {.Remove(startIndex, lenght)}
    {
        password = password.Remove(startIndex, length);
        Console.WriteLine(password);
        return password;
    }

    private static StringBuilder TakeOdd(StringBuilder password)                                // Метод за взимане на нечетните индекси 
    {
        StringBuilder result = new StringBuilder();

        for (int i = 1; i < password.Length; i += 2)                                             // Започвам от 1 и прескачам с 2 -> така взимам нечетните числа
        {
            result.Append(password[i]);
        }

        Console.WriteLine(result);
        return result;
    }
}
