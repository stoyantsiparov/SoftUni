using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveChild(string childFullName)
        {
            Child childToRemove = Registry.Find(c => $"{c.FirstName} {c.LastName}" == childFullName);
            if (childToRemove != null)
            {
                Registry.Remove(childToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ChildrenCount => Registry.Count;

        public Child GetChild(string childFullName) =>
            Registry.FirstOrDefault(c => $"{c.FirstName} {c.LastName}" == childFullName);

        public string RegistryReport()
        {
            var orderedChildren = Registry.OrderByDescending(c => c.Age)
                .ThenBy(c => c.LastName)
                .ThenBy(c => c.FirstName);

            StringBuilder sb = new();

            sb.AppendLine($"Registered children in {Name}:");

            foreach (var child in orderedChildren)
            {
                sb.AppendLine(child.ToString());
            }
            
            return sb.ToString().TrimEnd();
        }
    }
}
