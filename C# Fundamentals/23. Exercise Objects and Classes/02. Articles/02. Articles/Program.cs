class Articles
{
    public Articles(string title, string content, string author)    // Създавам конструктор на класа, за да съм сигурен, че ще ми подадът данни
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public void Edit(string newContent)                             // Метод, в който записвам новото съдържание на мястото на старото
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)                      // Метод, в който записвам новия автор на мястото на стария
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)                             // Метод, в който записвам новото заглавие на мястото на старото
    {
        Title = newTitle;
    }

    public override string ToString()                               // Метод който принтира
    {
        return $"{Title} - {Content}: {Author}";
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        string[] articleInput = Console.ReadLine()                  // Чета информацията от конзолата влагам в масив и разделям елементите в него по ", "
            .Split(", ");
        string title = articleInput[0];                             // Първия елемент е заглавието намиращо се на индекс [0]
        string content = articleInput[1];                           // Втория елемент е съдържанието намиращо се на индекс [1]
        string author = articleInput[2];                            // Третия елемент е автора намиращ се на индекс [2]

        Articles article = new Articles(title, content, author);    // Правя обект на класа, в който взимам елементите от променливите горе

        int n = int.Parse(Console.ReadLine());                      // Въвеждат ми от конзолата колко пъти ще трябва да променя масива

        for (int i = 0; i < n; i++)                                 // Обикалям целия масив до колкото пъти ми е казано от конзолата
        {
            string[] command = Console.ReadLine()                   // Чета командите от конзолата влагам в масив и разделям елементите в него по ": "
                .Split(": ");
            string commandType = command[0];                        // Типа на командата е на индекс [0]
            string commandOperation = command[1];                   // Промяната, която трябва да се извърши на старато команда е на индекс [1]

            switch (commandType)                                    // Търся ТИПА НА КОМАНДАТА
            {
                case "Edit":                                        // Ако е "Edit" влизам и изпълнявам метода за смяна на съдържание
                    article.Edit(commandOperation);
                    break;
                case "ChangeAuthor":                                // Ако е "ChangeAuthor" влизам и изпълнявам метода за смяна на автор
                    article.ChangeAuthor(commandOperation);
                    break;
                case "Rename":                                      // Ако е "Rename" влизам и изпълнявам метода за смяна на заглавие
                    article.Rename(commandOperation);
                    break;
            }
        }

        Console.WriteLine(article);                                 // Принтирам
    }
}