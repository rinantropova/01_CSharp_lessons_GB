

int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] table = new int[rowCount, columnsCount];

    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 1000);
        }
    }
    return table;
}



void Showmatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]} ");
            
        }
        Console.WriteLine();
    }
}




int[,] matrix = CreateMatrix(3, 4);
Showmatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}




bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}



int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}