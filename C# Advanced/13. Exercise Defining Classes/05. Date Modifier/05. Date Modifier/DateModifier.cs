using System;

namespace DateModifier;
// Когато направя класа {static} не мога да създавам {new() class DateModifier}
public static class DateModifier
{
    public static int GetDifferenceInDays(string start, string end)
    {
        DateTime startDate = DateTime.Parse(start);
        DateTime endDate = DateTime.Parse(end);

        // Променливата {TimeSpan} връща  отрязък от датите  
        TimeSpan differance = endDate - startDate;

        int differenceInDays = differance.Days;
        return Math.Abs(differenceInDays);
    }
}