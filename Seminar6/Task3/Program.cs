// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// My approach:
// Console.WriteLine("Please, enter your sentence: ");
// string str = Console.ReadLine();
// int vowelsInString = GetVowelsFromString(str);
// Console.Write($"Number of vowels is: {vowelsInString}");

// int GetVowelsFromString(string letters)
// {
//     var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};

//     int vowelCount = letters.Count(c => vowels.Contains(char.ToLower(c)));
//     int consonantCount = letters.Count(c => char.IsLetter(c) && !vowels.Contains(char.ToLower(c)));
//     return vowelCount;

// }


// Seminar's solution:

int CountVowelsLetters(string str)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        // for (int j = 0; j < vowels.Length; j++)
        // {
            if(vowels.Contains(str[i])) //vowels[j] == str[i]
            {
                count++;
            }
        // }
    }
    return count;
}

Console.WriteLine("Please, enter your sentence: ");
string str = Console.ReadLine();
int vowelsInWord = CountVowelsLetters(str);
Console.WriteLine($"In the string {str} there are {vowelsInWord} vowels");


