using System.Text;

namespace GenericCountMethodString;

public class Box<T> where T : IComparable
{
    private List<T> items;

    public Box()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public int Count(T itemCompare)
    {
        int count = 0;

        foreach (T item in items)
        {
            // Проверявам колко елементи от списъка (item) са по-големи от елемента за сравнение (itemCompare)
            if (item.CompareTo(itemCompare) > 0)
            {
                count++;
            }
        }

        return count;
    }
}