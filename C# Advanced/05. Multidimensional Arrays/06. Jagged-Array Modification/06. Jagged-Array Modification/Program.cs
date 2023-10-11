// Чета матрицата
int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] rowValues = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    matrix[row] = rowValues;
}

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] input = command.Split();
    int row = int.Parse(input[1]);
    int col = int.Parse(input[2]);
    int value = int.Parse(input[3]);

    // Проверявам дали координатите на елементите са в матрицата, ако НЕ са печатам ("Invalid coordinates")
    if (row < 0 || col < 0 || row >= matrix.Length || matrix[row].Length <= col)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else // ако ДА проверявам за команда от конзолата -> "add" или "remove" (на "add" добавям, а на "remove" махам елемент)
    {
        if (input[0] == "add")
        {
            matrix[row][col] += value;
        }
        else
        {
            matrix[row][col] -= value;
        }
    }

    command = Console.ReadLine().ToLower();
}


// Принтирам назъбената матрица
for (int row = 0; row < matrix.Length; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write($"{matrix[row][col]} ");
    }

    Console.WriteLine();
}