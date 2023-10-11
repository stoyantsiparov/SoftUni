using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Чета матрицата
        int[] size = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int rows = size[0];
        int cols = size[1];

        // Създавам матрицата
        int[,] matrix = new int[rows, cols];

        // Пълня матрицата с елементи
        for (int row = 0; row < rows; row++)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = numbers[col];
            }
        }

        // Създавам променливите, за да изчисля 3х3 матрицата
        int maxSum = 0;
        int maxSquareRow = 0;
        int maxSquareCol = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int newSum = Calculate3x3Sum(matrix, row, col);

                if (newSum > maxSum)
                {
                    maxSum = newSum;
                    maxSquareRow = row;
                    maxSquareCol = col;
                }
            }
        }

        // Принтирам резултата
        Console.WriteLine($"Sum = {maxSum}");
        Print3x3Submatrix(matrix, maxSquareRow, maxSquareCol);
    }

    // Калкулирам сумата на 3х3 матрицата от даден ред и колона
    static int Calculate3x3Sum(int[,] matrix, int startRow, int startCol)
    {
        int sum = 0;

        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                sum += matrix[row, col];
            }
        }

        return sum;
    }

    // Принтирам сумата на 3х3 матрицата от даден ред и колона
    static void Print3x3Submatrix(int[,] matrix, int startRow, int startCol)
    {
        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }
            Console.WriteLine();
        }
    }
}
