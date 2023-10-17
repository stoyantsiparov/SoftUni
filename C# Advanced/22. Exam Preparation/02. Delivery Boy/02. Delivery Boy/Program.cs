int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

char[,] matrix = new char[dimensions[0], dimensions[1]];

int boyRow = 0;
int boyCol = 0;

int boyInitialRow = 0;
int boyInitialCol = 0;

int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

for (int row = 0; row < rows; row++)
{
    string newRow = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = newRow[col];

        if (matrix[row, col] == 'B')
        {
            boyRow = row;
            boyCol = col;
            boyInitialRow = row;
            boyInitialCol = col;
        }
    }
}

bool isOutsideMatrix = false;

while (true)
{
    string command = Console.ReadLine();

    if (command == "left")
    {
        if (boyCol == 0)
        {
            if (matrix[boyRow, boyCol] == '-')
            {
                matrix[boyRow, boyCol] = '.';
            }

            isOutsideMatrix = true;

            Console.WriteLine("The delivery is late. Order is canceled.");

            break;
        }

        if (matrix[boyRow, boyCol - 1] == '*')
        {
            continue;
        }

        if (matrix[boyRow, boyCol] != 'R')
        {
            matrix[boyRow, boyCol] = '.';
        }

        boyCol--;
    }
    else if (command == "right")
    {
        if (boyCol == cols - 1)
        {
            if (matrix[boyRow, boyCol] == '-')
            {
                matrix[boyRow, boyCol] = '.';
            }

            isOutsideMatrix = true;

            Console.WriteLine("The delivery is late. Order is canceled.");

            break;
        }

        if (matrix[boyRow, boyCol + 1] == '*')
        {
            continue;
        }

        if (matrix[boyRow, boyCol] != 'R')
        {
            matrix[boyRow, boyCol] = '.';
        }

        boyCol++;
    }
    else if (command == "up")
    {
        if (boyRow == 0)
        {
            if (matrix[boyRow, boyCol] == '-')
            {
                matrix[boyRow, boyCol] = '.';
            }

            isOutsideMatrix = true;

            Console.WriteLine("The delivery is late. Order is canceled.");

            break;
        }

        if (matrix[boyRow - 1, boyCol] == '*')
        {
            continue;
        }

        if (matrix[boyRow, boyCol] != 'R')
        {
            matrix[boyRow, boyCol] = '.';
        }

        boyRow--;
    }
    else if (command == "down")
    {
        if (boyRow == rows - 1)
        {
            if (matrix[boyRow, boyCol] == '-')
            {
                matrix[boyRow, boyCol] = '.';
            }

            isOutsideMatrix = true;

            Console.WriteLine("The delivery is late. Order is canceled.");

            break;
        }

        if (matrix[boyRow + 1, boyCol] == '*')
        {
            continue;
        }

        if (matrix[boyRow, boyCol] != 'R')
        {
            matrix[boyRow, boyCol] = '.';
        }

        boyRow++;
    }

    if (matrix[boyRow, boyCol] == 'P')
    {
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");

        matrix[boyRow, boyCol] = 'R';

        continue;
    }

    if (matrix[boyRow, boyCol] == 'A')
    {
        Console.WriteLine("Pizza is delivered on time! Next order...");

        matrix[boyRow, boyCol] = 'P';

        break;
    }
}

if (isOutsideMatrix)
{
    matrix[boyInitialRow, boyInitialCol] = ' ';
}
else
{
    matrix[boyInitialRow, boyInitialCol] = 'B';
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }

    Console.WriteLine();
}