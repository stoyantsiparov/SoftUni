List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

Random phrase = new Random();                               // Класа  {Random} прави подредбата на елементите в списъка променлива (всеки път ще бъде различна)
Random event1 = new Random();
Random author = new Random();
Random town = new Random();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int phraseIndex = phrase.Next(0, phrases.Count);        // Метода {phrase.Next} в класа {Random} избира данните (в границите от {0} до {phrases.Count}) които да се изпишат
    int eventIndex = phrase.Next(0, events.Count);
    int authorIndex = phrase.Next(0, authors.Count);
    int citiesIndex = phrase.Next(0, cities.Count);
    Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[citiesIndex]}");
}