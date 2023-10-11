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

// Създавам променлива, в която да пазя стойността на сумата
int sum = 0;

// Добавям всяка 1 клетка от матрицата в променливата {sum}
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        sum += matrix[row, col];
    }
}

// Изпечатвам -> редовете, колоните и сумата на всички елементи в матрицата

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);