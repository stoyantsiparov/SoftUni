class Students
{
    public Students(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Students> students = new List<Students>();                 // Тук добавям учениците от {students.Add(student)}

        for (int i = 0; i < n; i++)
        {
            List<string> command = Console.ReadLine()
                .Split(" ")
                .ToList();
            string firstName = command[0];
            string lastName = command[1];
            double grade = double.Parse(command[2]);

            Students student = new Students(firstName, lastName, grade);
            students.Add(student);                                      // Добавям ученика даден ми от конзолата в новия списък {List<Students> students} горе
        }
        
        students = students                                             // Сравнявам оценките на учениците и ги филтрирам от най-голяма към най-малка
            .OrderByDescending(students => students.Grade)
            .ToList();

        foreach (Students student in students)  
        {
            Console.WriteLine(student);
        }
    }
}