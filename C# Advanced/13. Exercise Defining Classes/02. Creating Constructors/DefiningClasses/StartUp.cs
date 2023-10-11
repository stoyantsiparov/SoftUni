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
        Person stoyan = new("Stoyan", 19);

        Console.WriteLine($"{stoyan.Name}: {stoyan.Age}");
    }
}
