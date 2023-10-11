// Дробно число -> колко пъти се повтаря

// Създавам списък
List<double> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToList();

// Създавам речник
Dictionary<double, int> numbersCount = new Dictionary<double, int>();

foreach (var number in numbers)
{
    if (!numbersCount.ContainsKey(number))
    {
        // Нямам запис с даденото число -> записвам го за 1ви път
        numbersCount.Add(number, 1);
    }
    else
    {
        // Имам запис с даденото число -> увеличавам броя
        numbersCount[number]++;
    }
}

// Числото -> колко пъти се е срещтнало 
foreach (var entry in numbersCount)
{
    Console.WriteLine($"{entry.Key} - {entry.Value} times");
}