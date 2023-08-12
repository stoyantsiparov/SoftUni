using System.Text.RegularExpressions;

class Product
{
    public string ItemName { get; }

    public Product(string itemName, string expirationDate, int calories)
    {
        ItemName = itemName;
        ExpirationDate = expirationDate;
        Calories = calories;
    }

    public string Name { get; set; }
    public string ExpirationDate { get; set; }
    public int Calories { get; set; }
}
internal class Program
{
    public static void Main(string[] args)
    {
        int caloriesPerDay = 2000;
        string input = Console.ReadLine();

        string pattern = @"([|#])\b(?<item>[A-Za-z\s]+)\1(?<expiration>\d{2}/\d{2}/\d{2})\1(?<calories>\d{1,4})\1";

        List<Product> products = new List<Product>();
        foreach (Match match in Regex.Matches(input, pattern))
        {
            string itemName = match.Groups["item"].Value;
            string expirationDate = match.Groups["expiration"].Value;
            int calories = int.Parse(match.Groups["calories"].Value);
            products.Add(new Product(itemName, expirationDate, calories));
        }

        int days = products.Sum(x => x.Calories) / caloriesPerDay;                  // Смятам за колко дни ще имам храна, като всеки ден приемам по 2000 калории
        Console.WriteLine($"You have food to last you for: {days} days!");

        foreach (Product product in products)
        {
            Console.WriteLine($"Item: {product.ItemName}, Best before: {product.ExpirationDate}, Nutrition: {product.Calories}");
        }
    }
}