// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] table = new int[rowCount, columnCount];
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

void ShowMatrix(int[,] table)
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

int FindMinElement(int[,] table, out int row, out int column)
{
    int minElem = table[0, 0];
    row = 0;
    column = 0;

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i, j] < minElem)
            {
                minElem = table[i, j];
                row = i;
                column = j;

            }
        }
    }
    return minElem;
}

// int FindMinElementColumn(int[,] table)
// {
//     int minElem = table[0, 0];
//     int column = 0;
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             if (table[i, j] < minElem)
//             {
//                 minElem = table[i, j];
//                 column = j;
//             }
//         }
//     }
//     return column;
// }

int[,] RemoveRowColumnWithMin(int[,] table)
{
    int rows = table.GetLength(0);
    int columns = table.GetLength(1);
    int[,] newArray = new int[rows - 1, columns - 1];

    int minRow, minColumn;
    int minElem = FindMinElement(table, out minRow, out minColumn);

    for (int i = 0, j = 0; i < rows; i++)
    {
        if (i == minRow)
        {
            continue;
        }
        for (int k = 0, u = 0; k < columns; k++)
        {
            if (k == minColumn)
            {
                continue;
            }
            newArray[j, u] = table[i, k];
            u++;
        }
        j++;
    }
    return newArray;
}

void PrintResult(int[,] table)
{
    int[,] newArray = RemoveRowColumnWithMin(table);
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j],4} ");
        }
        Console.WriteLine();

    }
}


    int[,] matrix = CreateMatrix(3, 4, 1, 11);
    ShowMatrix(matrix);
    Console.WriteLine();
    PrintResult(matrix);
