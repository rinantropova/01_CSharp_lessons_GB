// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

Console.WriteLine("Please, enter a word: ");
string str = Console.ReadLine();

int fromEndIndex = str.Length - 1;
bool isPalindrome = true;
int halfSize = str.Length / 2;


for (int i = 0; i < halfSize; i++)
{

  if(str[i] != str[fromEndIndex])
    {
        isPalindrome = false;
        break;
    }
    fromEndIndex--;
}

if(isPalindrome)
{
    Console.WriteLine("=> Yes, it is a palindrome");
}
else
{
    Console.WriteLine("=> Not a palindrome");
}
    
