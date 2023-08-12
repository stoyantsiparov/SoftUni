using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "Delete":
                        list = DeleteNumber(list, int.Parse(arguments[1]));
                        break;
                    case "Insert":
                        list = InsertNumber(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }

        static List<int> InsertNumber(List<int> list, int number, int index)
        {
            list.Insert(index, number);

            return list;
        }

        static List<int> DeleteNumber(List<int> list, int number)
        {
            list.Remove(number);

            return list;
        }
    }
}
