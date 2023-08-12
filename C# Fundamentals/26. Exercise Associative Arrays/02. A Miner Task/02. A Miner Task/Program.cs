internal class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> resourceMap = new Dictionary<string, int>();

        string resource;
        int quantity;
        while ((resource = Console.ReadLine()) != "stop")
        {
            quantity = int.Parse(Console.ReadLine());
            
            // Тази проверка на КЛЮЧА винаги да е правя
            if (!resourceMap.ContainsKey(resource))         // Проверявам дали ключа е създаден
            {
                resourceMap.Add(resource, 0);               // Ако не е го създавам, но с празна стойност 
            }

            resourceMap[resource] += quantity;              // Пълня стойностите срещу ключа
        }

        foreach (KeyValuePair<string, int> pair in resourceMap)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}