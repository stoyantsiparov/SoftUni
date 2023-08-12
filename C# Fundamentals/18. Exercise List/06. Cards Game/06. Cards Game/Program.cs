using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwoDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerOneDeck.Count > 0 && playerTwoDeck.Count > 0)                  // Въртя цикъла, докато на единия играч не му останат никакви карти в тестето
            {
                int playerOneCard = playerOneDeck[0];                                   // Взимам първата карта на играч 1
                int playerTwoCard = playerTwoDeck[0];                                   // Взимам първата карта на играч 2

                if (playerOneCard > playerTwoCard)                                      // Проверявам дали картите на 1вия са по-големи от на 2рия
                {
                    RemovePlayerCardWhenCompared(playerOneDeck, playerTwoDeck);         // Премахвам 2те карти и след това ги сравнявам
                    playerOneDeck.Add(playerTwoCard);                                   // Ако картата му е по-голяма от на 2рия, 1вия взима картата на опонента си
                    playerOneDeck.Add(playerOneCard);                                   // и после добавя и своята карта
                }
                else if (playerTwoCard > playerOneCard)                                 // Проверявам дали картите на 2рия са по-големи от на 1вия
                {
                    RemovePlayerCardWhenCompared(playerOneDeck, playerTwoDeck);         // Премахвам 2те карти и след това ги сравнявам
                    playerTwoDeck.Add(playerOneCard);                                   // Ако картата му е по-голяма от на 1вия, 2рия взима картата на опонента си
                    playerTwoDeck.Add(playerTwoCard);                                   // и после добавя и своята карта
                }
                else
                {
                    RemovePlayerCardWhenCompared(playerOneDeck, playerTwoDeck);         
                }
            }

            if (playerOneDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOneDeck.Sum()}");
            }
            else if (playerTwoDeck.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwoDeck.Sum()}");
            }
        }

        private static void RemovePlayerCardWhenCompared(List<int> playerOneDeck, List<int> playerTwoDeck)
        {
            playerOneDeck.RemoveAt(0);
            playerTwoDeck.RemoveAt(0);
        }
    }
}
