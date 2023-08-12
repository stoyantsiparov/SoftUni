class User
{
    public User(string userName, string licensePlateNumber)
    {
        UserName = userName;
        LicensePlateNumber = licensePlateNumber;
    }

    public string UserName { get; set; }
    public string LicensePlateNumber { get; set; }
    public override string ToString()
    {
        return $"{UserName} => {LicensePlateNumber}";
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, User> database = new Dictionary<string, User>();

        int commmandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commmandsCount; i++)
        {
            string[] arguments = Console.ReadLine().Split();
            string command = arguments[0];
            string userName = arguments[1];

            switch (command)
            {
                case "register":
                    string licensePlateNumber = arguments[2];
                    User newUser = new User(userName, licensePlateNumber);
                    if (!database.ContainsKey(newUser.UserName))                                                            // Проверявам дали ключа е създаден
                    {
                        database.Add(newUser.UserName, newUser);                                                            // Ако не го създавам ключа
                        Console.WriteLine($"{newUser.UserName} registered {newUser.LicensePlateNumber} successfully");
                    }
                    else
                    {
                        User foundUser = database[newUser.UserName];                                                        // Ако ключа е създаден и се опита един {USER} да регистрира нова кола
                        Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlateNumber}");   // Изписва се това съобщение -> {USER} вече се регистриран
                    }
                    break;
                case "unregister":
                    if (database.ContainsKey(userName))                                                                     // Проверявам дали ключа е създаден
                    {
                        database.Remove(userName);                                                                          // Ако да го премахвам ключа
                        Console.WriteLine($"{userName} unregistered successfully");                                         // Изписва се това съобщение -> че {USER} вече се отрегистрира
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");                                             // Изписва се това съобщение -> {USER} не е намерен
                    }
                    break;
            }
        }

        foreach (KeyValuePair<string, User> pair in database)
        {
            Console.WriteLine(pair.Value);
        }

    }
}