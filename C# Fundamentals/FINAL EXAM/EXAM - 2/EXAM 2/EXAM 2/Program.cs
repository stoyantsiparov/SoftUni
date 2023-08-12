using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool validInput = false;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            string pattern = @"^\|([A-Z]{4,})\|:#([A-Za-z]+ [A-Za-z]+)#$";
            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                validInput = true;
                string bossName = match.Groups[1].Value;
                string titleName = match.Groups[2].Value;
                int nameStrength = bossName.Length;
                int titleStrength = titleName.Length;

                Console.WriteLine($"{bossName}, The {titleName}");
                Console.WriteLine($">> Strength: {nameStrength}");
                Console.WriteLine($">> Armor: {titleStrength}");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}