class Town
{
    public string Name { get; set; }
    public uint Population { get; set; }
    public uint Gold { get; set; }
}
internal class Program
{
    public static void Main(string[] args)
    {

        string input;
        Dictionary<string, Town> townDictionary = new Dictionary<string, Town>();

        while ((input = Console.ReadLine()) != "Sail")
        {
            string[] townArguments = input.Split("||");

            string townName = townArguments[0];
            uint population = uint.Parse(townArguments[1]);
            uint gold = uint.Parse(townArguments[2]);

            if (!townDictionary.ContainsKey(townName))                          // Проверявам дали ключа не е създаден
            {
                townDictionary.Add(townName, new Town());                       // Ако го няма създавам нов ключ
            }

            townDictionary[townName].Name = townName;
            townDictionary[townName].Population += population;                  // Тук е {+=}, защото ако се въведе отново същия град (ключ), просто добавям популацията към вече съществуващата такава
            townDictionary[townName].Gold += gold;                              // Тук е {+=}, защото ако се въведе отново същия град (ключ), просто добавям златото към вече съществуващото такова
        }

        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split("=>");
            string townName = arguments[1];

            switch (arguments[0])
            {
                case "Plunder":
                    uint killed = uint.Parse(arguments[2]);
                    uint gold = uint.Parse(arguments[3]);
                    Plunder(townDictionary, townName, killed, gold);
                    break;
                case "Prosper":
                    int goldEarn = int.Parse(arguments[2]);
                    if (goldEarn < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    Prosper(townDictionary, townName, (uint)goldEarn);
                    break;
            }
        }

        if (townDictionary.Count > 0)
        {
            Console.WriteLine($"Ahoy, Captain! There are {townDictionary.Count} wealthy settlements to go to:");
            foreach (Town town in townDictionary.Values)
            {
                Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
            }
        }
        else
        {
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }

    }

    private static void Prosper(Dictionary<string, Town> towns, string townName, uint goldEarn)
    {
        if (towns.ContainsKey(townName))
        {
            towns[townName].Gold += goldEarn;
            Console.WriteLine($"{goldEarn} gold added to the city treasury. {townName} now has {towns[townName].Gold} gold.");
        }
    }

    private static void Plunder(Dictionary<string, Town> towns, string townName, uint killed, uint gold)
    {
        if (towns.ContainsKey(townName))
        {
            towns[townName].Population -= killed;
            towns[townName].Gold -= gold;
            Console.WriteLine($"{townName} plundered! {gold} gold stolen, {killed} citizens killed.");

            if (towns[townName].Population <= 0 || towns[townName].Gold <= 0)   // Проверявам дали златото или популацията са достигнали 0 
            {
                towns.Remove(townName);                                         // Ако са премахвам града и отпечатвам долния ред
                Console.WriteLine($"{townName} has been wiped off the map!");
            }
        }
    }
}

