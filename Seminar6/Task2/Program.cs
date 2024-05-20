// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.

// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

string str = "Hello!";

// forbidden way to solve the task:
// char[] characters = str.ToCharArray();
// foreach (char letter in characters)
// {
//     Console.Write("'" + letter + "" + "'" + ",");
// }

// My attempt to solve it:
char[] charArray = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    charArray[i] = str[i];
}

Console.Write("[");
foreach(char letter in charArray)
{
    Console.Write("'" + letter + "'" + ", ");
}
Console.Write("]");