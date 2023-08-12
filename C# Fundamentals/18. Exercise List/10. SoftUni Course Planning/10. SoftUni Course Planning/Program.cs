using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string commands;
            while ((commands = Console.ReadLine()) != "course start")
            {
                string[] arguments = commands.Split(":");
                switch (arguments[0])
                {
                    case "Add":
                        schedule = AddTitle(schedule, arguments[1]);
                        break;
                    case "Insert":
                        schedule = InsertTitle(schedule, arguments[1], int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        schedule = RemoveTitle(schedule, arguments[1]);
                        break;
                    case "Swap":
                        schedule = SwapTitles(schedule, arguments[1], arguments[2]);
                        break;
                    case "Exercise":
                        schedule = InsertExercise(schedule, arguments[1]);
                        break;
                }
            }

            PrintSchedule(schedule);
        }

        private static void PrintSchedule(List<string> schedule)
        {
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");            // Принтирам индекса {i + 1} (номера на елемента) и {schedule[i]} (името на елемента)
            }                                                           // {i + 1}, защото искат номера на елемента да започва от 1
        }

        static List<string> AddTitle(List<string> schedule, string title)
        {
            if (!schedule.Contains(title))                               // {.Contains} проверява дали елемент се съдържа в списъка, а {!} означава НЕ(not)
            {
                schedule.Add(title);
            }

            return schedule;
        }

        static List<string> InsertTitle(List<string> schedule, string title, int index)
        {
            if (!schedule.Contains(title))                               // {.Contains} проверява дали елемент се съдържа в списъка, а {!} означава НЕ(not)
            {
                schedule.Insert(index, title);
            }

            return schedule;
        }

        static List<string> RemoveTitle(List<string> schedule, string title)
        {
            if (schedule.Contains(title))                               // {.Contains} проверява дали елемент се съдържа в списъка
            {
                schedule.Remove(title);                                 // {RemoveTitle} мерода ми трие името на Лекцията
            }

            string exerciseTitle = $"{title}-Exercise";                 // Добавям нова променлива {exerciseTitle}, в която съдържа Упражнението
            int index = schedule.IndexOf(exerciseTitle);                // Проверявам кой е индекса на дадение елемент {exerciseTitle}

            if (index >= 0)                                             // Проверявам дали съществува в списъка
            {
                RemoveTitle(schedule, exerciseTitle);                   // {RemoveTitle} мерода ми трие името на Упражнението
            }

            return schedule;
        }

        static List<string> SwapTitles(List<string> schedule, string firstTitle, string secondTitle)
        {
            if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle))
            {
                int firstTitleIndex = schedule.IndexOf(firstTitle);     // Проверявам кой е индекса на дадение елемент {firstTitle}
                int secondTitleIndex = schedule.IndexOf(secondTitle);   // Проверявам кой е индекса на дадение елемент {secondTitle}

                                                                        // Така сменям местата на {firstTitle} и {secondTitle} с вече намерените им индекси
                string temp = schedule[firstTitleIndex];                // Присвоявам в новата променлива {temp} променливата {schedule[firstTitleIndex]}        
                schedule[firstTitleIndex] = schedule[secondTitleIndex]; // Присвоявам в {schedule[firstTitleIndex]} променливата {schedule[secondTitleIndex]}
                schedule[secondTitleIndex] = temp;                      // Присвоявам в {{schedule[secondTitleIndex]}} променлива {temp}

                schedule = SwapExercises(schedule, firstTitle, secondTitleIndex);
                schedule = SwapExercises(schedule, secondTitle, firstTitleIndex);
            }

            return schedule;
        }

        static List<string> SwapExercises(List<string> schedule, string title, int titleIndex)
        {
            string exerciseTitle = $"{title}-Exercise";
            int index = schedule.IndexOf(exerciseTitle);

            if (index >= 0)                                                  // Проверявам дали съществува в списъка
            {
                RemoveTitle(schedule, exerciseTitle);
                InsertTitle(schedule, exerciseTitle, titleIndex + 1);   //1. Това {titleIndex + 1} прави, така че Лекцията да се изписва преди Упражнението
            }                                                                //2.  Изписва се {Databases} преди {Databeses-Exercise}

            return schedule;
        }

        static List<string> InsertExercise(List<string> schedule, string title)
        {
            if (!schedule.Contains(title))
            {
                AddTitle(schedule, title);
            }

            string exerciseTitle = $"{title}-Exercise";                     // Добавям нова променлива {exerciseTitle}, в която съдържа Упражнението
            if (schedule.Contains(title) && !schedule.Contains(exerciseTitle))
            {
                int titleIndex = schedule.IndexOf(title);
                InsertTitle(schedule, exerciseTitle, titleIndex + 1);  //1. Това {titleIndex + 1} прави, така че Лекцията да се изписва преди упражнението
                                                                            //2.  Изписва се {Databases} преди {Databeses-Exercise}
                // Втори начин --> {schedule.Insert(titleIndex, title);}, но ползвам вече създадения ми метод {InsertTitle}
            }

            return schedule;
        }
    }
}
