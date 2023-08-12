class Person    
{
    public Person(string name, string id, int age)
    {
        Name = name;
        ID = id;
        Age = age;
    }

    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} with ID: {ID} is {Age} years old.";
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split(" ");

            string name = arguments[0];
            string id = arguments[1];
            int age = int.Parse(arguments[2]);

            Person existingPerson = people.FirstOrDefault(p => p.ID == id);         // Проверявам дали съм получавал същото {ID} преди
            if (existingPerson != null)                                                   // Ако да въвеждам ново {ID} и ново име {Name}
            {
                existingPerson.Name = name;                 
                existingPerson.Age = age;
            }
            else                                                                          // Ако не добавям човека в списъка {List<Person>}
            {
                Person person = new Person(name, id, age);
                people.Add(person);
            }
        }

        List<Person> sortedPeople = people                                                // Сортирам хората в списъка по години във възходящ ред (най-малко към най-голямо)
            .OrderBy(p => p.Age)
            .ToList();

        foreach (Person person in sortedPeople)
        {
            Console.WriteLine(person);
        }
    }
}

