// Чета редовете и колоните
int[] sizes = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

// Инициализирам си редовете и колоните
int rows = sizes[0];
int cols = sizes[1];

// Създавам матрица
int[,] matrix = new int[rows, cols];

// Чета матрицата
for (int row = 0; row < rows; row++)
{
    // Чета стойностите на редовете
    int[] rowValues = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();

    // Записвам стойностите на колоните в дадения ред
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValues[col];
    }
}


int maxSquereRow = 0;
int maxSquereCol = 0;
int maxSquereSum = 0;

// matrix.GetLength(0) - 1 е дължината на матрицата - 1, защото така си гарантирам, че няма да изляза от размера на матрицата и да събирам несъществуващи елементи
for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        // Търся най-голямата сума, която образуват 4 непосредствено един го друг елемента в матрицата
        int currentSquereSum = matrix[row, col] +                                                       // Пример -> 9 8
                               matrix[row, col + 1] +                                                   //        -> 7 9
                               matrix[row + 1, col] +
                               matrix[row + 1, col + 1];
        if (currentSquereSum > maxSquereSum)
        {
            maxSquereSum = currentSquereSum;
            maxSquereRow = row;
            maxSquereCol = col;
        }
    }
}

// Изпечатвам 2та реда от квадрата с най-големия сбор на числа
Console.WriteLine($"{matrix[maxSquereRow, maxSquereCol]} {matrix[maxSquereRow, maxSquereCol + 1]}");            // Реда     -> 9 8
// Изпечатвам 2те колони от квадрата с най-големия сбор на числа                                                // Колоната -> 7 9
Console.WriteLine($"{matrix[maxSquereRow + 1, maxSquereCol]} {matrix[maxSquereRow + 1, maxSquereCol + 1]}");    // Сумата   -> 33
Console.WriteLine(maxSquereSum);