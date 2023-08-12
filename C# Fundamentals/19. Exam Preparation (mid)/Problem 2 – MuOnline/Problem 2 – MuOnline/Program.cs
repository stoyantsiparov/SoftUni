using System;
using System.Linq;
using System.Threading;

namespace Problem_2___MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            string[] dungeonsRooms = Console.ReadLine()
                .Split('|')
                .ToArray();

            int currentRoom = 0;
            foreach (string room in dungeonsRooms)
            {
                currentRoom++;
                string[] roomTokens = room.Split(" ")
                    .ToArray();

                string encounter = roomTokens[0];
                int amount = int.Parse(roomTokens[1]);

                if (encounter == "potion")
                {
                    if (health + amount > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else
                    {
                        health += amount;
                        Console.WriteLine($"You healed for {amount} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                    continue;
                }

                if (encounter == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                    continue;
                }

                health -= amount;

                if (health <= 0)
                {
                    Console.WriteLine($"You died! Killed by {encounter}.");
                    Console.WriteLine($"Best room: {currentRoom}");
                    return;
                }

                Console.WriteLine($"You slayed {encounter}.");
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
