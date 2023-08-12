string[] input = Console.ReadLine().Split();

decimal result = Sum(input[0], input[1]);
Console.WriteLine(result);

decimal Sum(string first, string second)
{
    decimal sum = 0;

    int lenght = Math.Max(first.Length, second.Length);             // Проверявам кой {string} е по-голям

    for (int i = 0; i < lenght; i++)
    {
        if (i < first.Length && i < second.Length)
        {
            sum += first[i] * second[i];
        }
        else if (i < first.Length)
        {
            sum += first[i];
        }
        else if (i < second.Length)
        {
            sum += second[i];
        }

    }

    return sum;
}

