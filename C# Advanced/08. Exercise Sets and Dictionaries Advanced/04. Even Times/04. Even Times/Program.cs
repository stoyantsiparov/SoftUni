Dictionary<int, int> numbersCounts = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());

    // Ако го няма числото го добавям
    if (!numbersCounts.ContainsKey(number))
    {
        numbersCounts.Add(number, 0);
    }
    // Ако го има го увеличавам (Инкрементирам)
    numbersCounts[number]++;
}
// Взимам от {Dictionary} всички и да намеря ЕДИНСТВЕНОТО {Singlе}, което се дели на 0
int result = numbersCounts.Single(nc => nc.Value % 2 == 0).Key;

// Принт
Console.WriteLine(result);