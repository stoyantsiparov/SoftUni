using System.Text.RegularExpressions;

class Furniture
{
    public Furniture(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal Total()                                                                          // Метод с който смятам цялата цена
    {
        return Price * Quantity;
    }
}

internal class Program
{
    public static void Main(string[] args)
    {

        List<Furniture> furnitures = new List<Furniture>();                                         // Създавам си празен списък

        string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<quantity>\d+)";          // Направил съм си (pattern) в сайта regex101

        string input;
        while ((input = Console.ReadLine()) != "Purchase")                                          // Въртя цикъла, докато не получа командата -> {"Purchase"}
        {
            Regex r = new Regex(pattern);                                                           // ТАЗИ ЧАСТ НЕ МЕ ИНТЕРЕСУВА ТЯ Е -> TEMPLATE
            MatchCollection collection = r.Matches(input);                                          // ТАЗИ ЧАСТ НЕ МЕ ИНТЕРЕСУВА ТЯ Е -> TEMPLATE

            foreach (Match match in collection)                                                     // Обикалям колекцията
            {
                // ВИНАГИ СЕ ПИШЕ --> 1во {.Groups} след това името на групата и накрая, за да взема стойността се пише {.Value}

                string name = match.Groups["name"].Value;                                           // Създавам променлива, която ми пази групата {"name"} от {regex-a}
                decimal price = decimal.Parse(match.Groups["price"].Value);                         // Създавам променлива, която ми пази групата {"price"} от {regex-a}
                int quantity = int.Parse(match.Groups["quantity"].Value);                           // Създавам променлива, която ми пази групата {"quantity"} от {regex-a}

                Furniture f = new Furniture(name, price, quantity);
                furnitures.Add(f);                                                                  // Добавям НОВА -> мебел, нейната цена и бройка в празния списък
            }
        }

        Console.WriteLine("Bought furniture:");
        decimal totalSpend = 0m;
        foreach (Furniture furniture in furnitures)
        {
            Console.WriteLine(furniture.Name);
            totalSpend += furniture.Total();
        }

        Console.WriteLine($"Total money spend: {totalSpend:F2}");
    }
}
