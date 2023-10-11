Func<List<int>, List<int>> reverse = numbers =>
{
    List<int> result = new();

    // с {forr} ми създава обърнат {for} цикъл автоматично (списъка го обърната)
    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }

    return result;
};

Func<List<int>, Predicate<int>, List<int>> exclude = (numbers, match) =>
{
    List<int> result = new();

    foreach (int number in numbers)
    {
        // Ако елемент се дели на друг елемент С остатък, го добавям в новия списък
        if (!match(number))
        {
            result.Add(number);
        }
    }

    return result;
};


// Създавам си списъка
List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

// Създавам променлива, в която са числата на които трябва да се дели горния списък
int divider = int.Parse(Console.ReadLine());

// Създавам предикат, който проверява дали числата в списъка са четни
Predicate<int> checkEven = number =>
    number % divider == 0;

// Премахва числата, които отговарят на резултата от предиката горе (делят се без остатък)
numbers = exclude(numbers, checkEven);

// След това им обръщам реда (на целия списък)
numbers= reverse(numbers);

// Принтирам
Console.WriteLine(string.Join(" ", numbers));