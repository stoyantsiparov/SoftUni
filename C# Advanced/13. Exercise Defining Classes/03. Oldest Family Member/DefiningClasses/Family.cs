namespace DefiningClasses;

public class Family
{
    private List<Person> people;
    // Ако в класа имам списък ВИНАГИ трябва да инициализирам списъка в конструктор, за да работи
    public Family()
    {
        people = new List<Person>();
    }

    public List<Person> People
    {
        get
        {
            return this.people;
        }
        set
        {
            this.people = value;
        }
    }
    // Добавям хора в списъка
    public void AddMember(Person member)
    {
        this.People.Add(member);
    }
    // Метод да взема най-стария човек в списъка
    public Person GetOldestMember()
    {
        return this.People.MaxBy(p => p.Age);
    }
}