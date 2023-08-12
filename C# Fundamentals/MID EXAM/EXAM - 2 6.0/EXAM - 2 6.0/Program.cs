List<string> list = Console.ReadLine()
            .Split(", ")
            .ToList();

int blacklistedCount = 0;
int lostCount = 0;
string command;
while ((command = Console.ReadLine()) != "Report")
{
    string[] arguments = command.Split();

    switch (arguments[0])
    {
        case "Blacklist":
            BlacklistedFriendNames(arguments, list, blacklistedCount);
            break;
        case "Error":
            LostFriendNamesAfterError(arguments, list, lostCount);
            break;
        case "Change":
            ChangedFriendOldUsernameToNewOne(arguments, list);
            break;
    }
}

Console.WriteLine($"Blacklisted names: {blacklistedCount}");
Console.WriteLine($"Lost names: {lostCount}");
Console.WriteLine(string.Join(" ", list));

void BlacklistedFriendNames(string[] strings, List<string> list1, int i)
{
    string name = strings[1];
    if (list1.Contains(name))
    {
        list1[list1.IndexOf(name)] = "Blacklisted";
        Console.WriteLine($"{name} was blacklisted.");
        i++;
        blacklistedCount++;
    }
    else
    {
        Console.WriteLine($"{name} was not found.");
    }
}

void LostFriendNamesAfterError(string[] arguments1, List<string> list2, int lostCount1)
{
    int index = int.Parse(arguments1[1]);
    if (index >= 0 && index < list2.Count && list2[index] != "Blacklisted" && list2[index] != "Lost")
    {
        Console.WriteLine($"{list2[index]} was lost due to an error.");
        list2[index] = "Lost";
        lostCount1++;
        lostCount++;
    }
}

void ChangedFriendOldUsernameToNewOne(string[] strings1, List<string> list3)
{
    int indexTwo = int.Parse(strings1[1]);
    string newName = strings1[2];
    if (indexTwo >= 0 && indexTwo < list3.Count)
    {
        string currentName = list3[indexTwo];
        list3[indexTwo] = newName;
        Console.WriteLine($"{currentName} changed his username to {newName}.");
    }
}