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
        .Split(" ")
        .Select(int.Parse)
        .ToArray();

    // Записвам стойностите на колоните в дадения ред
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValues[col];
    }
}

// Обръщам колоните в редове, за да мога да ги сметна по-лесно (сумите на всяка една колона)
for (int col = 0; col < cols; col++)
{
    int sum = 0;

    for (int row = 0; row < rows; row++)
    {
        sum += matrix[row, col];
    }

    Console.WriteLine(sum);
}
