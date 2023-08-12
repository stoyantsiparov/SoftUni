string input = Console.ReadLine();
string[] usernames = input.Split(", ");

foreach (var username in usernames)
{
    if (username.Length < 3 || username.Length > 16)    
    {
        continue;
    }

    // Проверявам дали масива от {char-ове} -> {string-a} е валиден по дадените параметри долу -> да има букви, числа {IsLetterOrDigit}, тире '-', и долна черта '_'
    bool isValidUsername = username.All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_');

    if (isValidUsername)
    {
        Console.WriteLine(username);
    }
}