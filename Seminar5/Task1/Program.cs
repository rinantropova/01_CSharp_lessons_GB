
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

int[,] matrix = CreateMatrix(4, 5);
Showmatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i % 2 == 0 && j % 2 == 0)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

Showmatrix(matrix);