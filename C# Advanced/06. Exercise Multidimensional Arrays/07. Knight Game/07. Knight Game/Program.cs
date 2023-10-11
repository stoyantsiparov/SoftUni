int size = int.Parse(Console.ReadLine());

if (size < 3 && size >29)
{
    Console.WriteLine(0);
    return;
}

int countRemoved = 0;                       // Брой премахнати коне
char[,] matrix = new char[size, size];

for (int row = 0; row < size; row++)        // Обхождам редовете
{
    char[] simbols = Console.ReadLine().ToArray();

    for (int col = 0; col < size; col++)    // Обхождам колоните
    {
        matrix[row, col] = simbols[col];    // Пълня матрицата с елементи
    }
}

// Обхождам полето и премахвам коне, докато не остана само с добри коне -> не атакуват други коне
while (true)
{
    int maxAttack = 0;      // Брой на максимум атаки от кон
    int rowMaxAttack = 0;   // Ред на най-атакуващия кон
    int colMaxAttack = 0;   // Колона на най-атакуващия кон

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            char currentElement = matrix[row, col];
            if (currentElement == 'K')
            {
                int countAttackedKnights = CalculateAttackedKnights(row, col, size, matrix);
                // Проверявам дали коня е най-атакуващия
                if (countAttackedKnights > maxAttack) // Търся коня с най-много атаки
                {
                    maxAttack = countAttackedKnights;
                    rowMaxAttack = row;
                    colMaxAttack = col;
                }
            }
        }
    }
    // Намирам най-атакуващия кон
    if (maxAttack==0)
    {
        // Няма кон, които да атакува -> прекратявам проверката
        break;
    }
    else
    {
        // Имам кон за премахване -> махам го и го заменям с 0
        matrix[rowMaxAttack, colMaxAttack] = '0';
        countRemoved++;
    }
}

Console.WriteLine(countRemoved);

static int CalculateAttackedKnights(int row, int col, int size, char[,] matrix)
{
    int count = 0;
    // 2 нагоре и 1 надясно -> ред -2, колона +1
    if (IsValid(row - 2, col + 1, size))
    {
        // Съществурат такива ред и колона -> проверявам дали има кон
        if (matrix[row - 2, col + 1] == 'K')
        {
            count++;
        }
    }
    // 2 нагоре и 1 наляво -> ред -2, колона -1
    if (IsValid(row - 2, col - 1, size))
    {
        // Съществурат такива ред и колона -> проверявам дали има кон
        if (matrix[row - 2, col - 1] == 'K')
        {
            count++;
        }
    }
    // 2 надолу и 1 наляво -> ред +2, колона -1
    if (IsValid(row + 2, col - 1, size))
    {
        // Съществурат такива ред и колона -> проверявам дали има кон
        if (matrix[row + 2, col - 1] == 'K')
        {
            count++;
        }
    }
    // 2 надолу и 1 надясно -> ред +2, колона +1
    if (IsValid(row + 2, col + 1, size))
    {
        // Съществурат такива ред и колона -> проверявам дали има кон
        if (matrix[row + 2, col + 1] == 'K')
        {
            count++;
        }
    }
    // 2 надясно и 1 надолу -> ред +1, колона +2
    if (IsValid(row + 1, col + 2, size))
    {
        // Съществурат такива ред и колона -> проверявам дали има кон
        if (matrix[row + 1, col + 2] == 'K')
        {
            count++;
        }
    }
    // 2 надясно и 1 нагоре -> ред -1, колона +2
    if (IsValid(row - 1, col + 2, size))
    {
        // Съществурат такива ред и колона -> проверявам дали има кон
        if (matrix[row - 1, col + 2] == 'K')
        {
            count++;
        }
    }
    // 2 наляво и 1 нагоре -> ред -1, колона -2
    if (IsValid(row - 1, col - 2, size))
    {
        // Съществурат такива ред и колона -> проверявам дали има кон
        if (matrix[row - 1, col - 2] == 'K')
        {
            count++;
        }
    }
    // 2 наляво и 1 надолу -> ред +1, колона -2
    if (IsValid(row + 1, col - 2, size))
    {
        // Съществурат такива ред и колона -> проверявам дали има кон
        if (matrix[row + 1, col - 2] == 'K')
        {
            count++;
        }
    }

    return count;
}

static bool IsValid(int row, int col, int size)
{
    return row >= 0 && row < size && col >= 0 && col < size;
}