using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();         // Създавам масив (в тези скоби [] се пишат индексите на масива)
            int rotations = int.Parse(Console.ReadLine());              

            for (int i = 0; i < rotations; i++)                  // Правя for цикъл, в който завъртам числата сподед дадените от конзолата ротации
            {
                string firstElement = array[0];                  // Взимам първия индекс на масива {array[0]} и го запазвам в променливата {firstElement}

                for (int j = 0; j < array.Length - 1; j++)       // Правя for цъкил, който обикаля по дължината на масива до предпоследния елемент {j < array.Length - 1}
                {
                    array[j] = array[j + 1];                     // В първия индекс на масива [j] който е = 0 присвоявам следващия индекс [j + 1], докато не се достигне последния индекс 
                }                                                // Пример на мястото на 51[0] присвоявам 47[1]. На мястото на 47[1] присвоявам 32[2] и т.н. до индекс [3]

                array[array.Length - 1] = firstElement;          // В последния индекс на масива [array.Length - 1] присвоявам първия елемент {array[0]}
            }                                                    // Пример на мястото на 21[array.Length - 1] присвоявам 51{firstElement = array[0]}

            Console.WriteLine(string.Join(" ", array));          // Принтирам отговор
        }
    }
}
