using System.Text;

internal class Program
{
    public static void Main(string[] args)
    {
        string message = Console.ReadLine();

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "Decode")
        {
            string[] arguments;
            arguments = input.Split("|");
            switch (arguments[0])
            {
                case "Move":
                    int countOfLetters = int.Parse(arguments[1]);
                    string temp = message.Substring(0, countOfLetters);       // Запазвам си {string-a} от {0} индекс до колкото ми е дадено от конзолата {countOfLetters}
                    message = message.Remove(0, countOfLetters);                    // Махам буквите от {0} индекс до колкото ми е дадено от конзолата {countOfLetters}
                    message = message + temp;                                                // Събирам запазения ми стринг с вече новия (след рязането) и запазения се премества отзад
                    break;
                case "Insert":
                    int indexToInsert = int.Parse(arguments[1]);
                    string valueToInsert = arguments[2];
                    message = message.Insert(indexToInsert, valueToInsert);
                    break;
                case "ChangeAll":
                    string substring = arguments[1];
                    string replacement = arguments[2];
                    message = message.Replace(substring, replacement);
                    break;
            }
        }

        Console.WriteLine($"The decrypted message is: {message}");
    }
}