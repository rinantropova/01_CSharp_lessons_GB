

int[,] CreateMatrix(int rowCount, int columnsCount, int min, int max)
{
    int[,] table = new int[rowCount, columnsCount];

    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(min, max);
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
            Console.Write($"{table[i, j], 4} ");

        }
        Console.WriteLine();
    }
}

int CalculateMainDiagonalArraySum(int[,] table)
{
    int sum = 0;

    // int minSize = table.GetLength(0);
    // if(table.GetLength(1) < minSize)
    // {
    //     minSize = table.GetLength(1);
    // }

    for (int i = 0; i < table.GetLength(0) && i < table.GetLength(1); i++)
    {
        sum += table[i, i];
    }
    return sum;
}

int[,] matrix = CreateMatrix(3, 4, 1, 11);
Showmatrix(matrix);
int mainDiagonalSum = CalculateMainDiagonalArraySum(matrix);
Console.WriteLine(mainDiagonalSum);