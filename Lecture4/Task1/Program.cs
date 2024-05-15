
// INITIAL SOLUTION WITHOUT FUNCTIONS:
// int[,] table = new int[3, 5];
// // int[,] - type
// // table - variable's name
// // new int[3, 5]; - memory slot selection for the 2D-array, size of the array, 3 - rows, 5 - amount of element in each line

// Random rnd = new Random();
// for (int i = 0; i < table.GetLength(0); i++)
// // table.GetLength(0) - request the length - amount of rows or columns, when it's 0 in () - we request amount of rows of 2D array
// {
//     for (int j = 0; j < table.GetLength(1); j++)
//     // table.GetLnegth(1) - we're requesting amount of columns in the array (because of 1)
//     {
//         table[i, j] = rnd.Next(1, 11);
//     }
// }

// for (int i = 0; i < table.GetLength(0); i++)
// {
//     for (int j = 0; j < table.GetLength(1); j++)
//     {
//         Console.Write($"{table[i, j]} ");
//         // this method of output is called intropolation
//     }
//     Console.WriteLine();
// }



//SOLUTION WITH FUNCTIONS:
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