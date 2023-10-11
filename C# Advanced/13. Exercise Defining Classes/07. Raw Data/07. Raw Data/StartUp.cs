namespace RawData;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Car> cars = new();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] carProps = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new(
                carProps[0],                    // model
                int.Parse(carProps[1]),         // speed
                int.Parse(carProps[2]),         // power
                int.Parse(carProps[3]),        // weight
                carProps[4],                     // type
                double.Parse(carProps[5]),// tyre1pressure
                int.Parse(carProps[6]),       // tyre1age
                double.Parse(carProps[7]),// tyre2pressure
                int.Parse(carProps[8]),       // tyre2age
                double.Parse(carProps[9]),// tyre3pressure
                int.Parse(carProps[10]),       // tyre3age
                double.Parse(carProps[11]),// tyre4pressure
                int.Parse(carProps[12]));      // tyre4age

            cars.Add(car);
        }

        string command = Console.ReadLine();

        string[] filteredCarModels;

        if (command == "fragile")
        {
            filteredCarModels = cars
                .Where(c => c.Cargo.Type == "fragile" && c.Tyres.Any(t => t.Pressure < 1))
                .Select(c => c.Model)
                .ToArray();
        }
        else
        {
            filteredCarModels = cars
                .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToArray();
        }

        Console.WriteLine(string.Join(Environment.NewLine, filteredCarModels));
    }
}