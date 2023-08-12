using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string person = string.Empty;
            if (age >= 0 && age < 3)
            {
                person = "baby";
            }
            else if (age >= 3 && age < 14) 
            {
                person = "child";
            }
            else if (age >= 14 && age < 20)
            {
                person = "teenager";
            }
            else if (age >= 20 && age < 66)
            {
                person = "adult";
            }
            else if (age >= 66)
            {
                person = "elder";
            }
            Console.WriteLine(person);
        }
    }
}
