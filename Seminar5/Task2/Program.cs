

int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] table = new int[rowCount, columnsCount];

    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 11);
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

int CalculateMainDiagonalArraySum(int[,] table)
{
    int sum = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        sum += table[i, i];
    }
    return sum;
}

int[,] matrix = CreateMatrix(4, 5);
Showmatrix(matrix);
int mainDiagonalSum = CalculateMainDiagonalArraySum(matrix);
Console.WriteLine(mainDiagonalSum);