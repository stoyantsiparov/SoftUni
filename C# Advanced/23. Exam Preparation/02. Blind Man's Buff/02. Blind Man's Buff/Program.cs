int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];

int blindManRow = 0;
int blindManCol = 0;

int touched = 0;
int moves = 0;

for (int row = 0; row < rows; row++)
{
    string[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentRow[col];

        if (matrix[row, col] == "B")
        {
            blindManRow = row;
            blindManCol = col;

            matrix[blindManRow, blindManCol] = "-";
        }
    }
}

string command;

while ((command = Console.ReadLine()) != "Finish")
{
    if (command == "up")
    {
        if (blindManRow == 0)
        {
            continue;
        }
        if (matrix[blindManRow - 1, blindManCol] == "O")
        {
            continue;
        }
        blindManRow--;
    }

    else if (command == "down")
    {
        if (blindManRow == rows - 1)
        {
            continue;
        }
        if (matrix[blindManRow + 1, blindManCol] == "O")
        {
            continue;
        }
        blindManRow++;
    }
    else if (command == "right")
    {
        if (blindManCol == cols - 1)
        {
            continue;
        }
        if (matrix[blindManRow, blindManCol + 1] == "O")
        {
            continue;
        }
        blindManCol++;
    }
    else if (command == "left")
    {
        if (blindManCol == 0)
        {
            continue;
        }
        if (matrix[blindManRow, blindManCol - 1] == "O")
        {
            continue;
        }
        blindManCol--;
    }
    moves++;
    if (matrix[blindManRow, blindManCol] == "P")
    {
        touched++;
        matrix[blindManRow, blindManCol] = "-";

        if (touched == 3)
        {
            break;
        }
    }
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touched} Moves made: {moves}");