using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        long fieldLength = int.Parse(Console.ReadLine());
        int[] bugPlaces = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        long[] field = new long[fieldLength];

        for (int i = 0; i < bugPlaces.Length; i++)
        {
            int currentIndex = bugPlaces[i];
            // If цикъла пречи да се въвеждат числа извън дължината на масива
            if (currentIndex >= 0 && currentIndex < field.Length)
            {
                field[currentIndex] = 1;
            }
        }

        string command = string.Empty;

        while ((command = Console.ReadLine()) != "end")
        {
            // {"0" "right" "1"} - това са командите
            string[] elements = command.Split();	                    // масива
            int bugIndex = int.Parse(elements[0]);	                    // "0" - index на калинката
            string direction = elements[1];		                        // "right" - посока на движение
            int flyLength = int.Parse(elements[2]);	                    // "1" - с колко стъпки ще се движи

            if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
            {
                continue;
            }

            field[bugIndex] = 0;			                            // на 0 няма калинка, затова е 0

            if (direction == "right")
            {
                int landIndex = bugIndex + flyLength;	                // къде каца калинката, след като е полетяла

                if (landIndex > field.Length - 1)	                    // Проверява да не е излязло от масива
                {
                    continue;
                }

                if (field[landIndex] == 1)		                        // проверява дали има калинка на това място, където ще каца новата
                {
                    while (field[landIndex] == 1)
                    {
                        landIndex += flyLength;
                        if (landIndex > field.Length - 1)
                        {
                            break;
                        }
                    }
                }

                if (landIndex <= field.Length - 1)
                {
                    field[landIndex] = 1;
                }
            }
            else if (direction == "left")		                        // същото като "right", обаче е отрицателно
            {
                int landIndex = bugIndex - flyLength;	                // къде каца калинката, след като е полетяла


                if (landIndex < 0)			                            // Проверява да не е излязло от масива
                {
                    continue;
                }

                if (field[landIndex] == 1)		                        // проверява дали има калинка на това място, където ще каца новата	
                {
                    while (field[landIndex] == 1)
                    {
                        landIndex -= flyLength;
                        if (landIndex < 0)
                        {
                            break;
                        }
                    }
                }

                if (landIndex >= 0)
                {
                    field[landIndex] = 1;
                }
            }
        }

        Console.WriteLine(string.Join(" ", field));
    }
}