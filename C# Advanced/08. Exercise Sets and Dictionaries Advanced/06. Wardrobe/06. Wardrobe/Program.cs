Dictionary<string, Dictionary<string, int>> colorsClothes = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries); // Така сплитвам по нов масив (така сплитвам 2 знака едновременно)

    string color = tokens[0];

    if (!colorsClothes.ContainsKey(color))
    {
        // Ключ цвета и добавям още едно {Dictionary}, в което ще се записват другите неща (ключ - дрехите) и (стойност - колко пъти се срещтат)
        colorsClothes.Add(color, new Dictionary<string, int>());
    }

    //{j = 1}, а не на {0} (защото почвам от следващия токен, а горе вече съм почнал от 0 {string color = tokens[0]})
    for (int j = 1; j < tokens.Length; j++)
    {
        string currentWear = tokens[j];

        if (!colorsClothes[color].ContainsKey(currentWear))
        {
            colorsClothes[color].Add(currentWear, 0);
        }

        // Добавям в вътрешното {Dictionary} (инкрементирам) ако имам от дадения цвят някаква дреха
        colorsClothes[color][currentWear]++;
    }
}

string[] findParameters = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

// {foreach-вам} ВЪНШНИЯ речник
foreach (var colorClothes in colorsClothes)
{
    Console.WriteLine($"{colorClothes.Key} clothes:");

    // {foreach-вам} ВЪТРЕШНИЯ речник
    foreach (var wearCount in colorClothes.Value)
    {
        string printWear = $"* {wearCount.Key} - {wearCount.Value}";

        string color = findParameters[0];
        string wear = findParameters[1];

        if (colorClothes.Key == color && wearCount.Key == wear)
        {
            printWear += " (found!)";
        }

        Console.WriteLine(printWear);
    }
}