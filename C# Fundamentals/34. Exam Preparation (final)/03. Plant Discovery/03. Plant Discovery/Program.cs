class Plant
{
    public Plant(string name, int rarity)
    {
        Name = name;
        Rarity = rarity;
        Ratings = new List<int>();
    }

    public string Name { get; set; }
    public int Rarity { get; set; }

    public List<int> Ratings { get; set; }
}
internal class Program
{
    public static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        List<Plant> plants = new List<Plant>();
        for (int i = 0; i < input; i++)
        {
            string[] arguments = Console.ReadLine().Split("<->");
            string name = arguments[0];
            int rarity = int.Parse(arguments[1]);
            if (plants.Any(x => x.Name == name))
            {
                plants.FirstOrDefault(x => x.Name == name).Rarity = rarity;
            }
            else
            {
                plants.Add(new Plant(name, rarity));
            }
        }

        string line = string.Empty;
        while ((line = Console.ReadLine()) != "Exhibition")
        {
            string[] arguments = line.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
            string plantName = arguments[1];
            if (!plants.Any(x => x.Name == plantName))
            {
                Console.WriteLine("error");
                continue;
            }
            switch (arguments[0])
            {
                case "Rate":
                    int rating = int.Parse(arguments[2]);
                    plants.FirstOrDefault(x=>x.Name == plantName).Ratings.Add(rating);
                    break;
                case "Update":
                    int rarity = int.Parse(arguments[2]);
                    plants.FirstOrDefault(x => x.Name == plantName).Rarity = rarity;
                    break;
                case "Reset":
                    plants.FirstOrDefault(x => x.Name == plantName).Ratings.Clear();
                    break;
            }
        }

        Console.WriteLine("Plants for the exhibition:");
        foreach (Plant plant in plants)
        {
            double rating = 0.0;
            if (plant.Ratings.Any())
            {
                rating = plant.Ratings.Average();
            }
            Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {rating:F2}");
        }
    }
}
