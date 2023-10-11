int size = int.Parse(Console.ReadLine());

string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

char[,] matrix = new char[size, size];
int currentRow = 0;   // Ред на стартиране
int currentCol = 0;   // Колона на стартиране
int countCoal = 0;    // Броя на въглищата

// Прочитам си матрицата от конзолата
for (int row = 0; row < size; row++)        // Обхождам редовете
{
    char[] symbols = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)    // Обхождам колоните
    {
        matrix[row, col] = symbols[col];    // Пълня матрицата с елементи
        if (symbols[col] == 's')            // Ако видя {'s'} започвам движението в матрицата от там
        {
            currentRow = row;
            currentCol = col;
        }
        else if (symbols[col] == 'c')       // Ако видя {'c'} запазвам броя на всички въглиюа в матрицата
        {
            countCoal++;
        }
    }
}

foreach (string direction in directions)
{
    // Валидни посоки -> up, down, left, right
    switch (direction)
    {
        case "left":    // колона -1
            // Валидирам мястото, на което ще отида преди преместването
            if (currentCol - 1 >= 0 && currentCol - 1 <= size - 1)
            {
                currentCol--;
                // Провекра къде съм отишъл
                char currentElement = matrix[currentRow, currentCol];
                if (currentElement == 'e')
                {
                    // Прекратявам цикъла с посоките на движение
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (currentElement == 'c')
                {
                    // Взимам въглищата от полето с буква {'c'} и слагам {*}
                    matrix[currentRow, currentCol] = '*';
                    // Взимам 1 въглен от всички изброени до сега
                    countCoal--;
                    // Ако вече няма повече въглени изписвам това съобщение долу
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
            }
            break;

        case "right":   // колона +1
            // Валидирам мястото, на което ще отида преди преместването
            if (currentCol + 1 >= 0 && currentCol + 1 <= size - 1)
            {
                currentCol++;
                // Провекра къде съм отишъл
                char currentElement = matrix[currentRow, currentCol];
                if (currentElement == 'e')
                {
                    // Прекратявам цикъла с посоките на движение
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (currentElement == 'c')
                {
                    // Взимам въглищата от полето с буква {'c'} и слагам {*}
                    matrix[currentRow, currentCol] = '*';
                    // Взимам 1 въглен от всички изброени до сега
                    countCoal--;
                    // Ако вече няма повече въглени изписвам това съобщение долу
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
            }
            break;

        case "up":      // ред -1
            // Валидирам мястото, на което ще отида преди преместването
            if (currentRow - 1 >= 0 && currentRow - 1 <= size - 1)
            {
                currentRow--;
                // Провекра къде съм отишъл
                char currentElement = matrix[currentRow, currentCol];
                if (currentElement == 'e')
                {
                    // Прекратявам цикъла с посоките на движение
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (currentElement == 'c')
                {
                    // Взимам въглищата от полето с буква {'c'} и слагам {*}
                    matrix[currentRow, currentCol] = '*';
                    // Взимам 1 въглен от всички изброени до сега
                    countCoal--;
                    // Ако вече няма повече въглени изписвам това съобщение долу
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
            }
            break;

        case "down":    // ред +1
            // Валидирам мястото, на което ще отида преди преместването
            if (currentRow + 1 >= 0 && currentRow + 1 <= size - 1)
            {
                currentRow++;
                // Провекра къде съм отишъл
                char currentElement = matrix[currentRow, currentCol];
                if (currentElement == 'e')
                {
                    // Прекратявам цикъла с посоките на движение
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (currentElement == 'c')
                {
                    // Взимам въглищата от полето с буква {'c'} и слагам {*}
                    matrix[currentRow, currentCol] = '*';
                    // Взимам 1 въглен от всички изброени до сега
                    countCoal--;
                    // Ако вече няма повече въглени изписвам това съобщение долу
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
            }
            break;
    }
}

Console.WriteLine($"{countCoal} coals left. ({currentRow}, {currentCol})");