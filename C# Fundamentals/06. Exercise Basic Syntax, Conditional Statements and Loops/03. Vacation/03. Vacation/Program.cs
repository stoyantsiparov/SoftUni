using System;
using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalMoney = 0;
            double pricePerPerPerson = 0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerPerson = 10.46;
                            break;
                    }

                    totalMoney = peopleCount * pricePerPerPerson;
                    if (peopleCount >= 30)
                    {
                        totalMoney -= (totalMoney * 15) / 100; //изчислявам %
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerPerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerPerPerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerPerPerson = 16;
                            break;
                    }

                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }

                    totalMoney = peopleCount * pricePerPerPerson;
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerPerson = 22.50;
                            break;
                    }

                    if (peopleCount > 9 && peopleCount < 21)
                    {
                        totalMoney -= (totalMoney * 5) / 100;
                    }

                    totalMoney = peopleCount * pricePerPerPerson;
                    break;
            }
            Console.WriteLine($"Total price: {totalMoney:F2}");
        }
    }
}
