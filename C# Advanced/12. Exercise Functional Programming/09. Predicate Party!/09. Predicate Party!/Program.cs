List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command;
while ((command = Console.ReadLine()) != "Party!")
{
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];

    if (action == "Remove")
    {
        // Премахвам от горния списък хората, които отговарят на дадена команда
        people.RemoveAll(GetPredicate(filter, value));
    }
    else
    {
        // Създавам нов списък, в който търся индекса на издирваните хора според дадена команда (за да се дублира човека)
        List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));
        // Обикалям новия списък, за да дублирам името на даден човек (добавям името на човека ВЕДНАГА след първото срещане на името)
        foreach (string person in peopleToDouble)
        {
            // Търся индекса на името
            int index = people.FindIndex(p => p == person);
            // Добавям дублираното име веднага след намеряния горе индекс 
            people.Insert(index, person);
        }
    }
}

if (people.Any())
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

// Метод, в който има 1 предикат с 3 различни условия и те се заменят според това, каква е командата от конзолата (ПРЕМАХВАМ хора според дадена команда)
static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);
        case "EndsWith":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;
    }
}