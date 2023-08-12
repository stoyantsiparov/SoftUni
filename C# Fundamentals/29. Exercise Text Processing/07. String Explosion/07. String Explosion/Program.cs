using System.Text;

string input = Console.ReadLine();

string output = ProcessExplosions(input);
Console.WriteLine(output);

string ProcessExplosions(string input)
{
    StringBuilder sb = new StringBuilder();
    int strenght = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '>')                                                // Ако имам този знак '>' си увеличавам силата на експлозията {strenght} със следващото число [i + 1] след знака '>'
        {
            sb.Append(input[i]);
            strenght += int.Parse(input[i + 1].ToString());                 // Взимам цифрата след този знак '>'
        }
        else if (strenght == 0)                                             // Проверявам дали няма {strenght-а} -> равен на 0 
        {
            sb.Append(input[i]);                                            // Изпечатвам символа (буквата) в {StringBuilder-а}
        }
        else                                                                // Ако знака не е '>' и {strenght-а} не е равен на 0, и тогава тябва да го намаля с 1
        {
            strenght--;                                                     // Намалям {strenght-а} с 1
        }
    }

    return sb.ToString();
}