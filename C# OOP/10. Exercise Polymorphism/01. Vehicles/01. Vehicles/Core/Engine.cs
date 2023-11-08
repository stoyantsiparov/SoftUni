using Vehicles.Core.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core;

public class Engine : IEngine
{
    // {readonly} се инциализира САМО веднъж (повече не може да извиква надолу в кода)
    private readonly IReader reader;
    private readonly IWriter writer;

    // Създавам колекция {ICollection}, а не {List}, защото не ми трябват токова методи, не използвам и {IEnumerable}, защото няма метода {.Add} (добавям {ICollection}, защото искам само да добавя и {foreeach-на} елементите)
    private readonly ICollection<IVehicle> vehicles;

    public Engine(IReader reader, IWriter writer)
    {
        this.reader = reader;
        this.writer = writer;

        vehicles = new List<IVehicle>();
    }
    public void Run()
    {
        string[] tokens = reader.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        vehicles.Add(new Car(double.Parse(tokens[1]), double.Parse(tokens[2])));

        tokens = reader.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        vehicles.Add(new Truck(double.Parse(tokens[1]), double.Parse(tokens[2])));

        int commandCount = int.Parse(reader.ReadLine());

        for (int i = 0; i < commandCount; i++)
        {
            try
            {
                ProcessCommand();
            }
            catch (Exception ex)
            {
                writer.WriteLine(ex.Message);
            }
        }

        foreach (var vehicle in vehicles)
        {
            writer.WriteLine(vehicle.ToString());
        }
    }

    private void ProcessCommand()
    {
        string[] commandTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string command = commandTokens[0];
        string vehicleType = commandTokens[1];

        IVehicle vehicle = vehicles
            .FirstOrDefault(v => v.GetType().Name == vehicleType);

        if (vehicle == null)
        {
            throw new ArgumentException("Invalid vehicle type");
        }

        if (command == "Drive")
        {
            double distance = double.Parse(commandTokens[2]);
            writer.WriteLine(vehicle.Drive(distance));
        }
        else if (command == "Refuel")
        {
            double fuelAmount = double.Parse(commandTokens[2]);
            vehicle.Refuel(fuelAmount);
        }
    }
}