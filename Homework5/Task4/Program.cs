// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

int[,] CreateMatrix (int rowCount, int columnCount, int min, int max)
{
    int[,] table = new int[rowCount, columnCount];
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; i < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(min, max);
        }
    }
    return table;
}

void ShowMatrix(int[,] table)
{
    for(int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i,j], 4} ");
        }
        Console.WriteLine();
    }
}




int[,] matrix = CreateMatrix(3, 4, 1, 11);
Showmatrix(matrix);
Console.WriteLine();