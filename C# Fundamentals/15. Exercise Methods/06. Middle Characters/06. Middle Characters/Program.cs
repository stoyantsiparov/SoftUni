using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetMiddleElement(input);
            Console.WriteLine(GetMiddleElement(input));
        }

        private static string GetMiddleElement(string input)
        {
            int len = input.Length;
            string result = "";

            if (len % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }

            return result;
        }
    }
}
