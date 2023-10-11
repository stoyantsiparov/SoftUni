Action<string[], Predicate<string>> print = (names, match) =>
{
    // Принтирам всички имена, само ако съвпада с дадено условие
    foreach (string name in names)
    {
        if (match(name))
        {
            Console.WriteLine(name);
        }
    }
};

// Дава се от конзолата позволената дължина на име, за да може да се принтира
int legth = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

// Принтирам всяко име, което има същата дължина или по-малка от дадена в променливата {legth} от конзолата 
print(names, n => n.Length <= legth);