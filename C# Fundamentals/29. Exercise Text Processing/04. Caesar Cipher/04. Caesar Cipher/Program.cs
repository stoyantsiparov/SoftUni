using System.Net.Security;
using System.Text;

string input = Console.ReadLine();

Console.WriteLine(Encrypt(input));

string Encrypt(string input)
{
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < input.Length; i++)
    {
        char originalChar = input[i];                           // За всяка буква взимам нейния (char), на който отговаря от ASCII таблицата и я превъща в число

        sb.Append((char)(originalChar + 3));                    // Добавям (числата + 3), за да ги разбъркам и пиша (char) пред добавянето на числата, за да ги превърна отново в букви
    }


    return sb.ToString();
}