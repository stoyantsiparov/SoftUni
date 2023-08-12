using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numsAsStr = "";
            while ((numsAsStr = Console.ReadLine()) != "END")
            {
                Console.WriteLine(isPalindrome(numsAsStr));
            }
        }

         static bool isPalindrome(string input)
        {
            char[] arr = input.ToCharArray();                                           // Така се взима целия {string input} и го поставя в масив
             
            Array.Reverse(arr);                                                         // Обръша масива отзад - напред

            string second = new string(arr);                                            // Създавам {string} от вече обърнатия масив

            return input == second;
        }
    }
}
