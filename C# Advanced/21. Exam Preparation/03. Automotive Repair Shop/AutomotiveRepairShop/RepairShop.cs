using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            return Vehicles.Remove(Vehicles.FirstOrDefault(v => v.VIN == vin));
        }

        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            return Vehicles.MinBy(v => v.Mileage);
        }

        public string Report()
        {
            StringBuilder sb = new();
            sb.AppendLine("Vehicles in the preparatory:");

            foreach (var vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}