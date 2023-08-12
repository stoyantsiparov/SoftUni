class Product
{
    public Product(string name, decimal price, decimal quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }

    public void Update(decimal price, decimal quantity)
    {
        Price = price;
        Quantity += quantity;
    }

    public override string ToString()
    {
        return $"{Name} -> {Price * Quantity}";
    }

}

internal class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string product;
        while ((product = Console.ReadLine()) != "buy")
        {
            string[] arguments = product.Split();
            string name = arguments[0];
            decimal price = decimal.Parse(arguments[1]);
            decimal quantity = decimal.Parse(arguments[2]);

            Product newProduct = new Product(name, price, quantity);

            if (!products.ContainsKey(newProduct.Name))                                     // Проверявам дали ключа е създаден
            {
                products.Add(newProduct.Name, newProduct);                                  // Ако не е го създавам, но с празни стойности (само ключ)
            }
            else                                                                            // Ако съществува
            {
                products[newProduct.Name].Update(newProduct.Price, newProduct.Quantity);    // Пълня стойностите срещу ключа (ако е създаден вече)
            }
        }

        foreach (Product p in products.Values)                                              // Обикалям класа ми {Product}, но само неговите стойности {products.Values}
        {
            Console.WriteLine(p);
        }
    }
}