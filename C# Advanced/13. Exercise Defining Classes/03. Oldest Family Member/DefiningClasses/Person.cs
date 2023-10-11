namespace DefiningClasses;

public class Person
{
    private string name;
    private int age;

    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }
    // В конструкторите оператора {this()} свързва конструкторите (така няма смисъл да повтарям код)
    // {this.Name = "No name";} се повтаря горе, затова като напиша {this()} то си го взима само
    public Person(int age) : this()
    {
        this.Age = age;
    }
    // {this.Age = age;} се повтаря горе, затова като напиша {this(age)} то си го взима само
    public Person(string name, int age) : this(age)
    {
        this.Name = name;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }
}