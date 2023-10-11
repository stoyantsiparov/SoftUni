int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)        // Обхождам редовете
{
    string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)    // Обхождам колоните
    {
        matrix[row, col] = words[col];      // Пълня матрицата с елементи
    }
}

string command = Console.ReadLine();
while (command != "END")
{
    // Валидирам командата
    if (IsValidCommand(command, rows, cols))
    {
        // Ако е валидна командата -> изпълнявам
        string[] splittedComand = command.Split(" ");
        string element1 = matrix[int.Parse(splittedComand[1]), int.Parse(splittedComand[2])];
        string element2 = matrix[int.Parse(splittedComand[3]), int.Parse(splittedComand[4])];

        matrix[int.Parse(splittedComand[1]), int.Parse(splittedComand[2])] = element2;
        matrix[int.Parse(splittedComand[3]), int.Parse(splittedComand[4])] = element1;

        PrintMatrix(matrix);
    } // Ако не е валидна -> не изпълнявам
    else
    {
        Console.WriteLine("Invalid input!");
    }

    command = Console.ReadLine();
}


static bool IsValidCommand(string command, int rows, int cols)
{
    string[] commandParts = command.Split(" ");

    // Проверявам дали е написана правилна командата
    bool isValidName = commandParts[0] == "swap";

    // Проверявам дали дължината на командата е правилна
    bool isValidParts = commandParts.Length == 5;

    bool isValidRowsAndCols = false;
    if (isValidName && isValidParts)
    {
        int row1 = int.Parse(commandParts[1]); // ред на 1вия елемент
        int col1 = int.Parse(commandParts[2]); // колона на 1вия елемент
        int row2 = int.Parse(commandParts[3]); // ред на 2рив елемент
        int col2 = int.Parse(commandParts[4]); // колона на 2рия елемент

        // Валидни ли са редовете и колоните в матрицата
        isValidRowsAndCols = row1 >= 0 && row1 < rows
                             && col1 >= 0 && col1 < cols
                             && row2 >= 0 && row2 < rows
                             && col2 >= 0 && col2 < cols;
    }

    return isValidName && isValidParts && isValidRowsAndCols;
}

static void PrintMatrix(string[,] matrix)
{
    // matrix.GetLength(0) -> дава броя на редовете
    // matrix.GetLength(1) -> дава броя на колоните
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}