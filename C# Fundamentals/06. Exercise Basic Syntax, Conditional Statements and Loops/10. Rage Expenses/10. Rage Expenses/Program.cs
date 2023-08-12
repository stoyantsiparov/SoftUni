using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int lostGameCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            float headsetThrashed = 0f;
            float mouseThrashed = 0f;
            float keyboardThrashed = 0f;
            float displayThrashed = 0f;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetThrashed++;
                }
                if (i % 3 == 0)
                {
                    mouseThrashed++;
                }

                if (i % 6 == 0)
                {
                    keyboardThrashed++;

                    if (i % 12 == 0)
                    {
                        displayThrashed++;
                    }
                }

            }
            double expenses = (headsetPrice * headsetThrashed) + (mousePrice * mouseThrashed) + (keyboardPrice * keyboardThrashed) + (displayPrice * displayThrashed);

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");

            // Втори начин на РЕШЕНИЕ
            // int lostGameCount = int.Parse(Console.ReadLine());
            // float headsetPrice = float.Parse(Console.ReadLine());
            // float mousePrice = float.Parse(Console.ReadLine());
            // float keyboardPrice = float.Parse(Console.ReadLine());
            // float displayPrice = float.Parse(Console.ReadLine());
            // double expenses = 0;

            // int headsetThrashed = lostGameCount / 2;
            // int mouseThrashed = lostGameCount / 3;
            // int keyboardThrashed = lostGameCount / 6;
            // int displayThrashed = lostGameCount / 12;

            // expenses = headsetPrice * headsetThrashed + mousePrice * mouseThrashed + keyboardPrice * keyboardThrashed + displayPrice * displayThrashed;
            // Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
