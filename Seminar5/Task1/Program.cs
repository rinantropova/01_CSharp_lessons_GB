// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

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
        // Console.Write("|");
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j],4} ");

        }
        // Console.WriteLine(" |");
        Console.WriteLine();
    }
}

void EvenIndexElementToSquare(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i += 2)
    {
        for (int j = 0; j < table.GetLength(1); j += 2)
        {
            // if(i % 2 == 0 && j % 2 == 0)

            table[i, j] *= table[i, j];

        }
    }
}

int[,] matrix = CreateMatrix(4, 5, 1, 11);
Showmatrix(matrix);
EvenIndexElementToSquare(matrix);
Console.WriteLine();
Showmatrix(matrix);

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if(i % 2 == 0 && j % 2 == 0)
//         {
//             matrix[i, j] *= matrix[i, j];
//         }
//     }
// }

