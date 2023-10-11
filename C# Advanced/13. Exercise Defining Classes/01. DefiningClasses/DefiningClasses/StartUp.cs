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
        Person stoyan = new();

        stoyan.Name = "Stoyan";
        stoyan.Age = 19;

        Person daniel = new();

        daniel.Name = "Daniel";
        daniel.Age = 20;

        Console.WriteLine($"{stoyan.Name}:{stoyan.Age}");
        Console.WriteLine($"{daniel.Name}:{daniel.Age}");
    }
}

