int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)        // Обхождам редовете
{
    int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < size; col++)    // Обхождам колоните
    {
        matrix[row, col] = numbers[col];    // Пълня матрицата с елементи
    }
}

// Сума от числата на главния диагонал -> номера на реда = номера на колоната
int primaryDiagonal = 0;

// Сума от числата на второстепенния диагонал -> номера на колоната = size - 1 - номера на реда
int secondaryDiagonal = 0;

// Обхождам матрицата
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        int element = matrix[row, col];     // Текущ елемент
        if (row == col)
        {
            // Елемент на главния диагонал
            primaryDiagonal += element;
        }

        if (col == size - 1 -row)
        {
            // Елемент на второстепенния диагонал
            secondaryDiagonal += element;
        }
    }
}

Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));