void AddUserToSide(SortedDictionary<string, SortedSet<string>> sortedDictionary, string s, string side1)
{
    if (!sortedDictionary.Values.Any(u => u.Contains(s)))
    {
        if (!sortedDictionary.ContainsKey(side1))
        {
            sortedDictionary.Add(side1, new SortedSet<string>());
        }

        sortedDictionary[side1].Add(s);
    }
}

SortedDictionary<string, SortedSet<string>> sidesUsers = new();

string command;
while ((command = Console.ReadLine()) != "Lumpawaroo")
{
    if (command.Contains('|'))
    {
        string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
        string side = tokens[0];
        string user = tokens[1];

        AddUserToSide(sidesUsers, user, side);
    }
    else
    {
        string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
        string side = tokens[1];
        string user = tokens[0];

        foreach (var sideUsers in sidesUsers)
        {
            if (sideUsers.Value.Contains(user))
            {
                sideUsers.Value.Remove(user);
                break;
            }
        }

        AddUserToSide(sidesUsers, user, side);

        Console.WriteLine($"{user} joins the {side} side!");
    }
}


foreach (var sideUsers in sidesUsers.OrderByDescending(su => su.Value.Count))
{
    // Проверявам дали в сортед сета има нещо
    if (sideUsers.Value.Any())
    {
        Console.WriteLine($"Side: {sideUsers.Key}, Members: {sideUsers.Value.Count}");

        foreach (var user in sideUsers.Value)
        {
            Console.WriteLine($"! {user}");
        }
    }
}