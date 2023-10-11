using System.Text;
using GenericCountMethodString;

Box<double> box = new();
// Дава ми се елемент, който показва какъв ще е броя на елементите за сравнение
int count = int.Parse(Console.ReadLine());

// Обикалям до края на горния елемент (ако е 3 -> въртя 3 пъти)
for (int i = 0; i < count; i++)
{
    // Чета другите елементи
    double item = double.Parse(Console.ReadLine());

    // Добавям новите елементи в списък в класа {Box}
    box.Add(item);
}

// Добавям елемента, с който трябва да сравнявам горните (от класа {Box})
double itemToCompare = double.Parse(Console.ReadLine());
// Принтирам по-големите елементи от този за сравнение
Console.WriteLine(box.Count(itemToCompare));