string input = Console.ReadLine();
Stack<char> stack  = new Stack<char>();
// Добавям елементите в Стека
foreach (var character in input)
{
    stack.Push(character);
}
// Изписвам елементите в Стека наобратно
while (stack.Count > 0)
{
    Console.Write(stack.Pop());
}