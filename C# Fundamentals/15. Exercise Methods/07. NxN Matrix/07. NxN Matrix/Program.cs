using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = ReturnMatrix(n);
            Console.WriteLine(result);
        }

        static string ReturnMatrix(int n)
        {
            string result = "";
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    result += $"{n} ";              // Прави редовете
                }

                result += "\n";                     // Започва нов ред
            }

            return result;
        }
    }
}