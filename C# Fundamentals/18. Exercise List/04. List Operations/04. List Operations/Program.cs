using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(' ');    // Правя масив от {string-ове}, за да разделя командите които се получават от конзолата по празни редове
                switch (arguments[0])                                // (така няма да взема само първата буква от Add,а цялото)
                {
                    case "Add":
                        list = AddNumber(list, int.Parse(arguments[1]));
                        break;
                    case "Insert":
                        list = InsertNumber(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        list = RemoveAtIndex(list, int.Parse(arguments[1]));
                        break;
                    case "Shift":
                        switch (arguments[1])
                        {
                            case "left":
                                list = ShiftLeft(list, int.Parse(arguments[2]));
                                break;
                            case "right":
                                list = ShiftRight(list, int.Parse(arguments[2]));
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
        static List<int> AddNumber(List<int> list, int number)
        {
            list.Add(number);                                         // Добавям число накрая в списъка
            return list;
        }
        static List<int> InsertNumber(List<int> list, int number, int index)
        {
            if (IsIndexOutOfBound(list, index))
            {
                list.Insert(index, number);                      // Вмъквам число на даден индекс
            }

            return list;
        }


        static List<int> RemoveAtIndex(List<int> list, int index)
        {
            if (IsIndexOutOfBound(list, index))
            {
                list.RemoveAt(index);                                // Премахвам число на даден индекс
            }

            return list;
        }
        static bool IsIndexOutOfBound(List<int> list, int index)
        {
            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Invalid index");
                return false;
            }

            return true;
        }
        static List<int> ShiftLeft(List<int> list, int count)
        {
            count %= list.Count;                                     // Този ред не позволява {count-а} да ми излеле от списъка, а го превърта

            List<int> shifted = list.GetRange(0, count);       // Взимам дължината на списъка от 1вия (индекс 0) елемент до този който ми се отпуска от конзолата
            list.RemoveRange(0, count);                        // Премахвам вече взетата част от списъка
            list.InsertRange(list.Count, shifted);                  // Добавям "премахнатата" част на списъка {2рата колекция shifted} след последния елемент
            return list;
        }
        static List<int> ShiftRight(List<int> list, int count)
        {
            count %= list.Count;                                    // Проверявам дали {count-а} се дели с остатък, прибавям остатъка към {count-а}, за да не превърти

            int lastIndex = list.Count - count;                     // Този ред не позволява {count-а} да ми излеле от списъка, а го превърта
            List<int> shifted = list.GetRange(lastIndex, count);    // Взимам дължината на списъка от последния елемент до този който ми се отпуска от конзолата
            list.RemoveRange(lastIndex, count);                     // Премахвам вече взетата част от списъка
            list.InsertRange(0, shifted);                     // Добавям "премахнатата" част на списъка {2рата колекция shifted} след 1вия елемент
            return list;
        }

    }
}
