class Articles
{
    public Articles(string title, string content, string author)        // Създавам конструктор на класа, за да съм сигурен, че ще ми подадът данни
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public override string ToString()                                   // Метод който принтира
    {
        return $"{Title} - {Content}: {Author}";
    }
}

internal class Program
{
    public static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());                          // Въвеждат ми от конзолата колко пъти ще трябва да променя масива

        for (int i = 0; i < n; i++)                                     // Обикалям целия масив до колкото пъти ми е казано от конзолата
        {
            string[] articleInput = Console.ReadLine()                  // Чета информацията от конзолата влагам в масив и разделям елементите в него по ", "
                .Split(", ");
            string title = articleInput[0];                             // Първия елемент е заглавието намиращо се на индекс [0]
            string content = articleInput[1];                           // Втория елемент е съдържанието намиращо се на индекс [1]
            string author = articleInput[2];                            // Третия елемент е автора намиращ се на индекс [2]

            Articles article = new Articles(title, content, author);    // Правя обект на класа, в който взимам елементите от променливите горе   

            Console.WriteLine(article);                                 // Принтирам
        }

    }
}