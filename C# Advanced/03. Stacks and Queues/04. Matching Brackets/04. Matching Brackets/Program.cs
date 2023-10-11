string expression = Console.ReadLine();

Stack<int> openingBrackets = new Stack<int>();
// Обикалям целия Стек по дължината му
for (int i = 0; i < expression.Length; i++)
{
    // Търся отваряща скоба '(' -> след като е намеря и запазвам индекса в променливата {openingBrackets}
    if (expression[i] == '(')
    {
        // Запазвам в Стека отварящата скоба в дадения индекс
        openingBrackets.Push(i);
    }
    // Търся затваряща скоба ')' -> след като е намеря и запазвам индекса в променливата {closingBrackedIndex}
    if (expression[i] == ')')
    {
        // Намерената затваряща скоба маха предната отваряща (най-близката до нея)
        int closingBrackedIndex = openingBrackets.Pop();
        // Изписвам резултата от началния запазен индекс {openingBrackets} до крайния запазен индекс {closingBrackedIndex} за всяка скоба
        Console.WriteLine(expression.Substring(closingBrackedIndex, i - closingBrackedIndex + 1));
    }
}