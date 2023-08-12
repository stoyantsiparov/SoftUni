class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split(" -> ");
            string companyName = arguments[0];
            string employeeId = arguments[1];

            if (!companyEmployees.ContainsKey(companyName))
            {
                companyEmployees.Add(companyName, new List<string>());
            }

            if (!companyEmployees[companyName].Contains(employeeId))
            {
                companyEmployees[companyName].Add(employeeId);
            }
        }

        foreach (var company in companyEmployees)
        {
            Console.WriteLine(company.Key);
            foreach (var employeeId in company.Value)
            {
                Console.WriteLine($"-- {employeeId}");
            }
        }
    }
}