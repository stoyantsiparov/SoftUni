int[] dimensions = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string[,] matrix = new string[dimensions[0], dimensions[1]];

int blindRow = -1;
int blindCol = -1;

int opponentsTouched = 0;
int moves = 0;

for (int row = 0; row < dimensions[0]; row++)
{
    string[] newRow = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < dimensions[1]; col++)
    {
        matrix[row, col] = newRow[col];
        if (matrix[row, col] == "B")
        {
            blindRow = row;
            blindCol = col;
            matrix[row, col] = "-";
        }
    }
}

string direction;
while ((direction = Console.ReadLine()) != "Finish")
{
    if ((direction == "left" && blindCol == 0) ||
        (direction == "right" && blindCol == matrix.GetLength(1) - 1) ||
        (direction == "up" && blindRow == 0) ||
        (direction == "down" && blindRow == matrix.GetLength(0) - 1))
    {
        continue;
    }

    switch (direction)
    {
        case "left":
            if (matrix[blindRow, blindCol - 1] == "O")
            {
                continue;
            }
            break;
        case "right":
            if (matrix[blindRow, blindCol + 1] == "O")
            {
                continue;
            }
            break;
        case "up":
            if (matrix[blindRow - 1, blindCol] == "O")
            {
                continue;
            }
            break;
        case "down":
            if (matrix[blindRow + 1, blindCol] == "O")
            {
                continue;
            }
            break;

    }
    
    moves++;
    switch (direction)
    {
        case "left":
            blindCol--;
            break;
        case "right":
            blindCol++;
            break;
        case "up":
            blindRow--;
            break;
        case "down":
            blindRow++;
            break;

    }

    if (matrix[blindRow, blindCol] == "P")
    {
        opponentsTouched++;
        matrix[blindRow, blindCol] = "-";

        if (opponentsTouched == 3)
        {
            break;
        }
    }
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {opponentsTouched} Moves made: {moves}");