using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> likedMeals = new Dictionary<string, List<string>>();
        Dictionary<string, int> unlikedMeals = new Dictionary<string, int>();

        string command;

        while ((command = Console.ReadLine()) != "Stop")
        {
            string[] arguments = command.Split('-');
            string guest = arguments[1];
            string meal = arguments[2];

            switch (arguments[0])
            {
                case "Like":
                    LikedMeals(guest, meal, likedMeals);
                    break;
                case "Dislike":
                    DislikedMeals(guest, meal, likedMeals, unlikedMeals);
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

        foreach (KeyValuePair<string, List<string>> kvp in likedMeals)
        {
            Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
        }

        Console.WriteLine($"Unliked meals: {unlikedMeals.Values.Sum()}");
    }
    static void DislikedMeals(string guest, string meal, Dictionary<string, List<string>> likedMeals, Dictionary<string, int> unlikedMealsCount)
    {
        if (likedMeals.ContainsKey(guest) == false)
        {
            Console.WriteLine($"{guest} is not at the party.");
        }
        else if (likedMeals[guest].Contains(meal) == false)
        {
            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
        }
        else
        {
            likedMeals[guest].Remove(meal);
            if (unlikedMealsCount.ContainsKey(meal) == false)
            {
                unlikedMealsCount[meal] = 0;
            }
            unlikedMealsCount[meal]++;
            Console.WriteLine($"{guest} doesn't like the {meal}.");
        }
    }
    static void LikedMeals(string guest, string meal, Dictionary<string, List<string>> likedMeals)
    {
        if (likedMeals.ContainsKey(guest) == false)
        {
            likedMeals[guest] = new List<string>();
        }

        if (likedMeals[guest].Contains(meal) == false)
        {
            likedMeals[guest].Add(meal);
        }
    }
}
