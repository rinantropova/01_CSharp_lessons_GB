// 1. Задайте массив символов (тип char []). 
// 2. Создайте строку из
// символов этого массива.

// Указание
// Конструктор строки вида string(char []) не использовать.

// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”




// First way to solve this task (but forbidden one):
// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string str = new string(chars);
// Console.Write(str);


// Solution, suggested by Copilot Bing
// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string str = string.Join("", chars);
// Console.Write(str);


//My attempt to solve it at the level of my real knowledge
// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// foreach(char letter in chars)
// {
//     Console.Write(letter + "");
// }


// Solution from the seminar (with functions):
string CharArrayToString(char[] arr)
{
    string res = string.Empty; // same as ""
    for (int i = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }
    return res;
}

char[] chars = new char[] {'a', 'b', 'c', 'd'};
string result = CharArrayToString(chars);
Console.Write(result);
