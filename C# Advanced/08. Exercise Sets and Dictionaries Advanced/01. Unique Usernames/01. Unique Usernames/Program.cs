﻿HashSet<string> userNames = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string userName = Console.ReadLine();

    userNames.Add(userName);
}

foreach (string userName in userNames)
{
    Console.WriteLine(userName);
}