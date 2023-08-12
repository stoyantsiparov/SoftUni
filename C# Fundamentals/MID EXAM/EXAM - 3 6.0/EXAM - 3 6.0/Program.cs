List<string> list = Console.ReadLine()
    .Split(", ")
    .ToList();

string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command.Split(" - ");
    switch (arguments[0])
    {
        case "Add":
            list = AddPhoneToTheStorage(list, arguments[1]);
            break;
        case "Remove":
            list = RemovePhoneOfTheStorage(list, arguments[1]);
            break;
        case "Bonus phone":
            InsertNewPhoneAfterTheOldOne(arguments, list);
            break;
        case "Last":
            list = PutTheExistingPhoneAtTheLastPosition(list, arguments[1]);
            break;
    }
}

Console.WriteLine(string.Join(", ", list));

static List<string> AddPhoneToTheStorage(List<string> list, string phone)
{
    if (IsItemExist(list, phone) == false)
    {
        list.Add(phone);
    }

    return list;

}
static List<string> RemovePhoneOfTheStorage(List<string> list, string phone)
{
    if (IsItemExist(list, phone))
    {
        list.Remove(phone);
    }

    return list;
}
static void InsertNewPhoneAfterTheOldOne(string[] arguments, List<string> list)
{
    string[] items = arguments[1].Split(":");
    int oldItemIndex = list.IndexOf(items[0]);
    if (oldItemIndex >= 0)
    {
        if (oldItemIndex >= list.Count)
        {
            list.Add(items[1]);
        }
        else
        {
            list.Insert(oldItemIndex + 1, items[1]);
        }
    }
}
static List<string> PutTheExistingPhoneAtTheLastPosition(List<string> list, string item)
{
    if (IsItemExist(list, item))
    {
        list.Remove(item);
        list.Add(item);
    }

    return list;
}
static bool IsItemExist(List<string> list, string phone)
{
    bool itemExists = false;

    foreach (string itemEx in list)
    {
        if (itemEx == phone)
        {
            itemExists = true;
            break;
        }
    }

    return itemExists;
}