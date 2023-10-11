Queue<string> children = new Queue<string>(Console.ReadLine().Split());
int tossCount = int.Parse(Console.ReadLine());
int tosses = 0;
// Въртя докато не остане само 1 дете (победителя)
while (children.Count > 1)
{
    // Увеличавам хвърлянията и махам първото добавено дете от опашката -> {children.Dequeue()}
    tosses++;
    string childWithPotato = children.Dequeue();
    // Ако броя хвърляния съвпада с тези необходими да изгорищ (дадени от конзолата) -> Детето излиза и хвърлянията се зануляват (почва да се брои отначало)
    if (tosses == tossCount)
    {
        tosses = 0;
        Console.WriteLine($"Removed {childWithPotato}");
    }
    // Ако хвърлянията не съвпадат с необходимия брой хвърляния добавям махнатото дете {children.Dequeue()} в края на опашката -> {children.Enqueue(childWithPotato)}
    else
    {
        children.Enqueue(childWithPotato);
    }
}

Console.WriteLine($"Last is {children.Dequeue()}");