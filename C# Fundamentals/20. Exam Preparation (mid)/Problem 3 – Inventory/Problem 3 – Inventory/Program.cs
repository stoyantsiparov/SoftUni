using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] arguments = command.Split(" - ");
                switch (arguments[0])
                {
                    case "Collect":
                        list = AddItem(list, arguments[1]);
                        break;
                    case "Drop":
                        list = RemoveItem(list, arguments[1]);
                        break;
                    case "Combine Items":
                        AddingNewItemAfterTheOldOne(arguments, list);
                        break;
                    case "Renew":
                        list = ChangeItemPositionToLastIndex(list, arguments[1]);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", list));

        }
        static List<string> AddItem(List<string> list, string item)
        {
            if (IsItemExist(list, item) == false)
            {
                list.Add(item);
            }

            return list;

        }
        static List<string> RemoveItem(List<string> list, string item)
        {
            if (IsItemExist(list, item))
            {
                list.Remove(item);
            }

            return list;
        }
        static void AddingNewItemAfterTheOldOne(string[] arguments, List<string> list)
        {
            string[] items = arguments[1].Split(":");
            int oldItemIndex = list.IndexOf(items[0]);
            if (oldItemIndex >= 0)
            {
                if (oldItemIndex >= list.Count)
                {
                    list.Add(items[1]);
                }
                else
                {
                    list.Insert(oldItemIndex + 1, items[1]);
                }
            }
        }
        static List<string> ChangeItemPositionToLastIndex(List<string> list, string item)
        {
            if (IsItemExist(list, item))
            {
                list.Remove(item);
                list.Add(item);
            }

            return list;
        }
        static bool IsItemExist(List<string> list, string item)
        {
            bool itemExists = false;

            foreach (string itemEx in list)
            {
                if (itemEx == item)
                {
                    itemExists = true;
                    break;
                }
            }

            return itemExists;
        }
    }
}
