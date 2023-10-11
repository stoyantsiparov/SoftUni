List<Predicate<int>> predicates = new();

int endRange = int.Parse(Console.ReadLine());

// Създавам {HashSet}, в който ми дават делителите от конзолата, за да ги деля на списъка по-горе
HashSet<int> dividers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

// Създавам масив, в който изписвам числа от {1} до {endRange} подадена цифра от конзолата
int[] numbers = Enumerable.Range(1, endRange).ToArray();

// Обикалям {HashSet}, в който ми дават делителите от конзолата
foreach (int divider in dividers)
{
    // Добавям всяко число, което се дели на даден делител без остатък в списъка {predicates}
    predicates.Add(n => n % divider == 0);
}

foreach (int number in numbers)
{
    // Създавам променлива, която проверява дали дадено число се дели
    bool isDevisible = true;

    foreach (var match in predicates)
    {
        // Ако числото не се дели без остатък, прекратявам програмата
        if (!match(number))
        {
            isDevisible = false;
            break;
        }
    }

    // Ако се дели -> Принтирам
    if (isDevisible)
    {
        Console.Write($"{number} ");
    }
}