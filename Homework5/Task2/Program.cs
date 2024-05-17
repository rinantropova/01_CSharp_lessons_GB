


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
            Console.Write($"{table[i, j],4} ");

        }
        Console.WriteLine();
        
    }
}

int[,] SwapFirstLastRows(int[,] table)
{
    int numRows = table.GetLength(0);
    int numCol = table.GetLength(1);
    int[,] swappedTable = new int[numRows, numCol];
    for (int j = 0; j < numCol; j++)
    {
        swappedTable[0, j] = table[numRows - 1, j];
        
    }
    for(int j = 0; j < numCol; j++)
    {
        swappedTable[numRows - 1, j] = table[0, j];
    }
    for (int i = 1; i < numRows - 1; i++)
    {
        for (int j = 0; j < numCol; j++)
        {
            swappedTable[i, j] = table[i, j];
        }
    }

    return swappedTable;
}

void PrintArray(int[,] table)
{
    int numRows = table.GetLength(0);
    int numCol = table.GetLength(1);
    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCol; j++)
        {
            
            Console.Write($"{table[i, j],4} ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = CreateMatrix(3, 4, 1, 11);
Showmatrix(matrix);
Console.WriteLine();
int[,] result = SwapFirstLastRows(matrix);
PrintArray(result);


