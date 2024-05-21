// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 
// a b c => “abcdef”
// d e f 


// char[,] array = new char[] { {'a', 'b', 'c'},
//                             {'d', 'e', 'f'} };




static string ConvertArrayToString(char[,] table)
{
    string str = string.Empty;


    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            str += table[i, j];

        }
    }

    return str;
}

char[,] table = {{'a', 'b', 'c'},
                {'d', 'e', 'f'},
                {'g', 'j', 'i'}};

string str = ConvertArrayToString(table);

Console.WriteLine(str);