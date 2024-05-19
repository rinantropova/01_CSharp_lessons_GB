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

int[] SumRows(int[,] table)
{
    int rowCount = table.GetLength(0);
    int columnCount = table.GetLength(1);
    int[] arraySum = new int[rowCount];

    for (int i = 0; i < rowCount; i++)
    {
        int sum = 0;
        for (int j = 0; j < columnCount; j++)
        {
            sum += table[i, j];
        }
        arraySum[i] = sum;
        
    }
    return arraySum;
}

int MinIndex(int[] arraySum)
{
    int minSum = arraySum[0];
    int minIndex = 0;
    for (int i = 0; i < arraySum.Length; i++)
    {
        
        if (arraySum[i] < minSum)
        {
            minSum = arraySum[i];
            minIndex = i;
        }
        
    }
    return minIndex;
    
}

void PrintResult (int[,] numbers)
{
    int [] array = SumRows(numbers);
    foreach (int elem in array)
{
    Console.Write($"{elem} ");
}
    
    Console.WriteLine();
    
    int minIndex = MinIndex(array);
    Console.Write(minIndex);
    
}

int[,] matrix = CreateMatrix(3, 4, 1, 11);
Showmatrix(matrix);
Console.WriteLine();
PrintResult(matrix);
