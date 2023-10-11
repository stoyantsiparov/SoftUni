SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

string command = Console.ReadLine();

while (command != "Revision")
{
    string[] commandParts = command.Split(", ");
    string shop = commandParts[0];
    string product = commandParts[1];
    double price = double.Parse(commandParts[2]);


    // Имам ли такъв магазин -> ако не го създавам
    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }

    // Добавям продуктите към магазина
    shops[shop].Add(product, price);

    command = Console.ReadLine();
}

foreach (var entry in shops)
{
    // entry: key(име на магазина) : value(речник с продуктите)
    Console.WriteLine(entry.Key + "->");

    // В {entry.Value} имам продукта {product.Key} и цената {product.Value}
    foreach (var product in entry.Value)
    {
        // key(име на продукта) : value(цена на продукта)
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}