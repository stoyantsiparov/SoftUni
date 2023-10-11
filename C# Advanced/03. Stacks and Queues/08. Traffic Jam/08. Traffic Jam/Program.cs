int n = int.Parse(Console.ReadLine());  
Queue<string> cars = new Queue<string>();
int passedCarsCount = 0;
string command = Console.ReadLine();

while (command != "end")
{
    //Ако е зелено минават {n} на брой коли
    if (command == "green")
    {
        for (int i = 0; i < n; i++)
        {
            // Ако няма повече коли спираме цикъла
            if (cars.Count == 0)
            {
                break;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            passedCarsCount++;
        }
    }
    // Ако командата не е {"green"}, значи добавяме нова кола в опашката
    else
    {
        cars.Enqueue(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");