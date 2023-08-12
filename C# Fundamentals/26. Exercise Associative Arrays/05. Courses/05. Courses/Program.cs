class Course
{
    public Course(string courseName)
    {
        CourseName = courseName;
        RegisteredStudents = new List<string>();
    }
    public string CourseName { get; }
    public List<string> RegisteredStudents { get; }

    public int RegisteredStudentsCount => RegisteredStudents.Count;                     // Намирам колко ученици участват в даден курс

    public void RegisterStudent(string studentName)
    {
        RegisteredStudents.Add(studentName);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Course> courses = new Dictionary<string, Course>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] inputParts = input.Split(" : ");
            string courseName = inputParts[0];
            string studentName = inputParts[1];

            if (!courses.ContainsKey(courseName))
            {
                Course newCourse = new Course(courseName);
                courses.Add(courseName, newCourse);
            }

            courses[courseName].RegisterStudent(studentName);
        }

        foreach (Course course in courses.Values)
        {
            Console.WriteLine($"{course.CourseName}: {course.RegisteredStudentsCount}");
            foreach (string studentName in course.RegisteredStudents)
            {
                Console.WriteLine($"-- {studentName}");
            }
        }
    }
}
