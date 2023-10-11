using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfInteger;
internal class Box<T>
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

    public override string ToString()
    {
        // Създавам си нов {StringBuilder}
        StringBuilder sb = new();
        // Въртя си всички входове
        foreach (T item in items)
        {
            // Записвам ги в {StringBuilder}
            sb.AppendLine($"{item.GetType()}: {item.ToString()}");
        }
        // Връщам резултата от {StringBuilder} с метода {.ToString()}
        return sb.ToString().TrimEnd();
    }
}
