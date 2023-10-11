int count = int.Parse(Console.ReadLine());

// Създавам речник от 2 елемента ключ (стринг) и стойност (списък)
Dictionary<string, List<decimal>> studentsGrade = new Dictionary<string, List<decimal>>();

for (int i = 1; i <= count; i++)
{
    string input = Console.ReadLine();

    // "John 5.20".Split() -> ["John", "5.20"]
    string name = input.Split()[0];                     // Пълня елементите на ключа
    decimal grade = decimal.Parse(input.Split()[1]);      // Пълня елементите на стойностите

    // Проверявам дали речника има дадения ключ (име)
    if (!studentsGrade.ContainsKey(name))
    {
        // Ако не го добавям
        studentsGrade.Add(name, new List<decimal>());
    }

    // След това добавям срещу ключа списъка със стойностите (оценките)
    studentsGrade[name].Add(grade);
}

foreach (var entry in studentsGrade)
{
    string name = entry.Key;
    List<decimal> grades = entry.Value;
    decimal average = grades.Average();

    Console.WriteLine($"{name} -> {string.Join(" ", grades.Select(grades => $"{grades:F2}"))} (avg: {average:F2})");
}
