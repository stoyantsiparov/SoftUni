using System.Text;

string input =  Console.ReadLine();

StringBuilder sb = new StringBuilder();
sb.Append(input[0]);                                    // Добавям си първоначалния символ отговарящ на индекс [0], за да се изпише

for (int i = 1; i < input.Length; i++)
{
    if (input[i] != input[i-1])                         // Сравнявам единия индекс с предишното място
    {
        sb.Append(input[i]);                            // Ако са различни ги изписвам в {StringBuilder-а} -> заедно
    }
}


Console.WriteLine(sb.ToString());