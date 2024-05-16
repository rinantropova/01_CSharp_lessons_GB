
string str = Console.ReadLine();
string numbers = GetNumbersFromString(str);
int[] result = new int[numbers.Length];
StringToArray(result, str);
PrintArray(result);

string GetNumbersFromString(string s)
{
    string digits = "";

    foreach (char e in s)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            digits += e;
        }
    }
    return digits;
}

void StringToArray(int[] digitsArray, string st)
{
        string digits = GetNumbersFromString(st);
        // int[] digitsArray = new int[digits.Length];

    for (int i = 0; i < digits.Length; i++)
    {
        digitsArray[i] = digits[i] - '0';
    }
    // return digitsArray;
}

void PrintArray(int[] digitsArray)
{
    foreach (int num in digitsArray)
    {
        Console.Write(num + " ");
    }
}