using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            bool lenghtCheckPassed = CheckLenght(pass);
            bool symbolCheckPassed = CheckSpecialSymbols(pass);
            bool twoDigitsCheckPassed = CheckForTwoDigits(pass);

            if (!lenghtCheckPassed)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }

            if (!symbolCheckPassed)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }

            if (!twoDigitsCheckPassed)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }

            if (lenghtCheckPassed && symbolCheckPassed && twoDigitsCheckPassed)
            {
                Console.WriteLine($"Password is valid");
            }
        }

        static bool CheckForTwoDigits(string pass)
        {
            int count = 0;
            foreach (char symbol in pass)
            {
                if (symbol >= 48 && symbol<= 57)
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return false;
            }
            return true;
        }

        static bool CheckSpecialSymbols(string pass)
        {
            foreach (char symbol in pass)
            {
                if (symbol >= 65 && symbol <= 90 ||
                    symbol >= 97 && symbol <= 122||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckLenght(string pass)
        {
            if (pass.Length < 6 || pass.Length > 10)
            {
                return false;
            }
            return true;
        }
    }
}
