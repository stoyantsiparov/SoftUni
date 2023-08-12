using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArrays = Console.ReadLine()                           // Взимам си масива от конзолата
                .Split('|', StringSplitOptions.RemoveEmptyEntries);     // Разделям получаваните елементи с тази черта {'|'} (по условие), а другата функция премахва празните стрингове ако има такива
                                                                                 // Така след всяка {'|'} елементите се запазват в даден индекс на масива
            List<string> symbols = ExtractSymbols(stringArrays);

            Console.WriteLine(string.Join(" ", symbols));
        }

        private static List<string> ExtractSymbols(string[] stringArrays)       // Метод за да извадя всеки елемент от масива (в даден индекс) и да го върна наобратно
        {
            List<string> result = new List<string>();

            for (int i = stringArrays.Length - 1; i >= 0; i--)                  // Обратен масив от {stringArrays.Length - 1} до {0} и намалям с {i--}, защото в условието се иска резултата да започва от последните дадени елементи към първите (наобратно)
            {
                string[] array = stringArrays[i]                                // Създавам нов масив, в който записвам елементите от 1вия масив но не с този знак {'|'}, а с празно пространство
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                result.AddRange(array);                                         // Добавям целия преработен масив (2рия) в списъка {result} и отпечатвам
            }

            return result;
        }
    }
}
