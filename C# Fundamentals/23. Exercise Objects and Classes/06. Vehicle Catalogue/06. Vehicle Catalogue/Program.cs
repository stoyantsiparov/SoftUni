using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{

    class Vehicle
    {
        public Vehicle(string type, string model, string color, decimal horsepower)
        {
            Type = type; 
            Model = model; 
            Color = color; 
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Horsepower { get; set; }

        public string Print()
        {
            string result = string.Empty;

            result += $"Type: {CapitalizeFirstLetter(Type)}\n";
            result += $"Model: {Model}\n";
            result += $"Color: {Color}\n";
            result += $"Horsepower: {Horsepower}";
            return result;
        }

        public string CapitalizeFirstLetter(string value)
        {
            char[] charArray = value.ToCharArray();
            if (char.IsLower(charArray[0]))
            {
                charArray[0] = char.ToUpper(charArray[0]);
            }

            return new string(charArray);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" ");
                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                decimal horsepower = decimal.Parse(arguments[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);
                catalogue.Add(vehicle);
            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle foundVehicle = catalogue.Find(vehicle => vehicle.Model == command);
                if (foundVehicle != null)
                {
                    Console.WriteLine(foundVehicle.Print());                            // Принтирам метода написан в класа

                }
            }

            decimal averageHP = catalogue
                .Where(vehicle => vehicle.Type == "car")                                // Търся вида на МПС-то да е {"car"} -> когато намери влиза в {.Select}
                .Select(vehicle => vehicle.Horsepower)                                  // Търся конските сили на всичките МПС-та
                .DefaultIfEmpty()                                                       // Пречи на метода {.Average()} да връща резултат {null} и да гърми
                .Average();                                                             // Смятам средните конски сили от всичките МПС-та

            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = catalogue
                .Where(vehicle => vehicle.Type == "truck")                              // Търся вида на МПС-то да е {"truck"} -> когато намери влиза в {.Select}
                .Select(vehicle => vehicle.Horsepower)                                  // Търся конските сили на всичките МПС-та
                .DefaultIfEmpty()                                                       // Пречи на метода {.Average()} да връща резултат {null} и да гърми
                .Average();                                                             // Смятам средните конски сили от всичките МПС-та

            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
        }
    }
}
