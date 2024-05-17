// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9 


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

int FindElementWithIndexes(int[,] table, int rowIndex, int columnIndex)
{
    bool found = false;
    int num = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i == rowIndex && j == columnIndex)
            {
                num = table[i,j];
                Console.WriteLine($"Number in the matrix with the entered indexes: {num}");
                found = true;
                break;
            }
            
        }
        if(found)
        {
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine($"There is no element with the insexes: ({rowIndex}, {columnIndex})");
    }
    return num;
}


int[,] matrix = CreateMatrix(3, 4, 1, 11);
Showmatrix(matrix);
Console.WriteLine("Enter a row index: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a column index: ");
int column = Convert.ToInt32(Console.ReadLine());

int result = FindElementWithIndexes(matrix, row, column);






