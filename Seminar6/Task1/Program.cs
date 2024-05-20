// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.

// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


char[] chars = new char[] {'a', 'b', 'c', 'd'};

// First way to solve this task (but forbidden one):
// string str = new string(chars);
// Console.Write(str);

// Solution, suggested by Copilot Bing
// string str = string.Join("", chars);
// Console.Write(str);

//My attempt to solve it at the level of my real knowledge
foreach(char letter in chars)
{
    Console.Write(letter + "");
}