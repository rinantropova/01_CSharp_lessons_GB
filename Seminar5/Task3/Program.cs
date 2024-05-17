// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// // значений по строкам двумерного массива. 




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

double[] CalculateRowsMean(int[,] table)
{
    int rowCount = table.GetLength(0);
    int columnCount = table.GetLength(1);
    double[] means = new double[rowCount];

    for (int i = 0; i < rowCount; i++)
    {
        int sum = 0;
        for (int j = 0; j < columnCount; j++)
        {
            sum += table[i, j];
        }
        means[i] = (double)sum / columnCount;
    }
    return means;
}

int[,] matrix = CreateMatrix(3, 4, 1, 11);
Showmatrix(matrix);
double[] rowMeans = CalculateRowsMean(matrix);

foreach (double avg in rowMeans)
{
    Console.Write($"{avg:F2} ");
}



