using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        Family family = new();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] personProperties = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            // Създавам човек в класа {personProperties[0] -> име} и {int.Parse(personProperties[1]) -> години}
            Person person = new(personProperties[0], int.Parse(personProperties[1]));

            family.AddMember(person);
        }

        Person oldest = family.GetOldestMember();

        Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}
