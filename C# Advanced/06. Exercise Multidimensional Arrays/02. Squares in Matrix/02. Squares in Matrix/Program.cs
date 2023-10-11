using System.Drawing;

int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)        // Обхождам редовете
{
    char[] simbols = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)    // Обхождам колоните
    {
        matrix[row, col] = simbols[col];    // Пълня матрицата с елементи
    }
}

// Броя на квадратите 2x2 в матрицата 
int count = 0;

// {cols - 1} и {rows - 1} са с -1, защото да не хвана последния ред и колона от матрицата и да не изляза от нея
for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        int element = matrix[row, col];
        // Дали съвпада с този вдясно от началния елемент
        bool isEqualRight = element == matrix[row, col + 1];
        // Дали съвпада с този долу от началния елемент
        bool isEqualBottom = element == matrix[row + 1, col];
        // Дали съвпада с този диагонал от началния елемент
        bool isEqualDiagonal = element == matrix[row + 1, col + 1];

        if (isEqualRight && isEqualBottom && isEqualDiagonal)
        {
            count++;
        }
    }
}

Console.WriteLine(count);