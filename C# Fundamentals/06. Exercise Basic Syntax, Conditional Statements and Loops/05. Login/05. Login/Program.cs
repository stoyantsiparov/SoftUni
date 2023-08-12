using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Login
{
    static class StringHelper                                               // Този клас {StringHelper} ми позволява да използвам {ReverseString} командата, която изписва даден {string} наобратно
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            for (int i = 0; i <= 3; i++)                                    // Проверявам колко пъти е пробвано нова парола, ако превиши 3 и още не е вярна програмата те блокира
            {
                if (i == 3)
                {
                    if (password == StringHelper.ReverseString(username))   // Този ред проверява дали паролата съвпада с обърнатото Име на акаунта {StringHelper.ReverseString(username))}
                    {
                        Console.WriteLine($"User {username} logged in.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                }
                else if (password == StringHelper.ReverseString(username))
                {
                    Console.WriteLine($"User {username} logged in.");
                        break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    password = Console.ReadLine();
                }
            }
        }
    }
}
