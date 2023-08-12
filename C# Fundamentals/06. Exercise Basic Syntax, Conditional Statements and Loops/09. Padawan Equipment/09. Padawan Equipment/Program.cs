using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsaberPriceTotal = Math.Ceiling((studentCount * 0.1) + studentCount) * lightsaberPrice;
            double robesPriceTotal = (studentCount * robesPrice);
            double beltPriceTotal = studentCount * beltsPrice;

            int freeBelt = studentCount / 6;

            double totalPrice = lightsaberPriceTotal + robesPriceTotal + (beltPriceTotal - (freeBelt * beltsPrice));
            double neededMoney = totalPrice - money;

            if (totalPrice > money)
            {
                Console.WriteLine($" John will need {neededMoney:F2}lv more.");
            }
            else if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
        }
    }
}
