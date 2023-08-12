using System;

namespace Problem_1___Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());                                // Броя на студентите
            int numLectures = int.Parse(Console.ReadLine());                                // Броя на лекциите
            int bonus = int.Parse(Console.ReadLine());                                      // Допълнителни бонус точки

            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < numStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());                            // Присъствието на студентите

                double totalBonus = (double)attendances / numLectures * (5 + bonus);        // Формула за калкулиране на всички бонус точки
                totalBonus = Math.Ceiling(totalBonus);                                      // Закръглям ги до по-горното число

                if (totalBonus > maxBonus)                                                  // Проверявам дали всички бонус точки на студент са по -големи от другите бонус точки на студент
                {
                    maxBonus = totalBonus;                                                  // Ако са ги запазвам в променливата {maxBonus}, така запазвам максималните бонус точки
                    maxAttendance = attendances;                                            // Ако присъствието му е повече от на другия студент го запазвам в {maxAttendance}
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");                                   // Принтирам максималните бонус точки на студент
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");       // Принтирам неговите присъствия в лекциите
        }
    }
}