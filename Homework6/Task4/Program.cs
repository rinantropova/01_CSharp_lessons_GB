// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// “Hello my world” => “world my Hello”



static string ReverseWords(string strNew)
{
    string[] strNewSplit = strNew.Split();

    string result = "";

    for (int i = strNewSplit.Length - 1; i >= 0; i--)
    {
        result += strNewSplit[i] + " ";
    }

    return result;
}


string strNew = "Hello my world";

string result = ReverseWords(strNew);

Console.WriteLine(result);