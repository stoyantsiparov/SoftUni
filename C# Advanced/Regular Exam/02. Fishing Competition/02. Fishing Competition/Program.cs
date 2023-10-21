
int size = int.Parse(Console.ReadLine());

int rows = size;
int cols = size;

char[,] matrix = new char[rows, cols];
int playerRow = 0;
int playerCol = 0;

int totalFishNeeded = 0;

for (int row = 0; row < rows; row++)
{
    string rowData = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowData[col];

        if (matrix[row, col] == 'S')
        {
            playerRow = row;
            playerCol = col;

            matrix[playerRow, playerCol] = '-';
        }
    }
}

string command;
while ((command = Console.ReadLine()) != "collect the nets")
{

    if (command == "right")
    {
        if (playerCol == cols - 1)
        {
            playerCol = 0;
            if (char.IsDigit(matrix[playerRow, playerCol]))
            {
                totalFishNeeded += int.Parse(matrix[playerRow, playerCol].ToString());
                matrix[playerRow, playerCol] = '-';
            }

            continue;
        }

        if (matrix[playerRow, playerCol + 1] == '-')
        {
            playerCol++;
            continue;
        }

        playerCol++;
    }
    else if (command == "left")
    {
        if (playerCol == 0)
        {
            playerCol = cols - 1;
            if (char.IsDigit(matrix[playerRow, playerCol]))
            {
                totalFishNeeded += int.Parse(matrix[playerRow, playerCol].ToString());
                matrix[playerRow, playerCol] = '-';
            }
            continue;
        }
        if (matrix[playerRow, playerCol - 1] == '-')
        {
            playerCol--;
            continue;
        }
        playerCol--;
    }
    else if (command == "down")
    {
        if (playerRow == rows - 1)
        {
            playerRow = 0;
            if (char.IsDigit(matrix[playerRow, playerCol]))
            {
                totalFishNeeded += int.Parse(matrix[playerRow, playerCol].ToString());
                matrix[playerRow, playerCol] = '-';
            }
            continue;
        }
        if (matrix[playerRow + 1, playerCol] == '-')
        {
            playerRow++;
            continue;
        }
        playerRow++;
    }
    else if (command == "up")
    {
        if (playerRow == 0)
        {
            playerRow = rows - 1;
            if (char.IsDigit(matrix[playerRow, playerCol]))
            {
                totalFishNeeded += int.Parse(matrix[playerRow, playerCol].ToString());
                matrix[playerRow, playerCol] = '-';
            }
            continue;
        }
        if (matrix[playerRow - 1, playerCol] == '-')
        {
            playerRow--;
            continue;
        }
        playerRow--;
    }

    if (matrix[playerRow, playerCol] == 'W')
    {
        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{playerRow},{playerCol}]");
        break;
    }
    if (char.IsDigit(matrix[playerRow, playerCol]))
    {
        totalFishNeeded += int.Parse(matrix[playerRow, playerCol].ToString());
        matrix[playerRow, playerCol] = '-';
    }

}
PrintResult(totalFishNeeded, matrix, playerRow, playerCol);

if (matrix[playerRow, playerCol] != 'W')
{
    matrix[playerRow, playerCol] = 'S';
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}
void PrintResult(int i, char[,] chars, int playerRow1, int playerCol1)
{
    if (i < 20 && chars[playerRow1, playerCol1] != 'W')
    {
        Console.WriteLine(
            $"You didn't catch enough fish and didn't reach the quota! You need {20 - i} tons of fish more.");
    }

    if (i >= 20 && chars[playerRow1, playerCol1] != 'W')
    {
        Console.WriteLine("Success! You managed to reach the quota!");
    }

    if (i > 0 && chars[playerRow1, playerCol1] != 'W')
    {
        Console.WriteLine($"Amount of fish caught: {i} tons.");
    }
}