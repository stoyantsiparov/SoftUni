using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            string biggestKegModel = "";
            double biggestKegVolume = 0;

            for (int i = 0; i < kegsCount; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int .Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height; // radius * radius също става, защото е на 2ра степен

                if (biggestKegVolume < volume)
                {
                    biggestKegModel = model;
                    biggestKegVolume = volume;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
