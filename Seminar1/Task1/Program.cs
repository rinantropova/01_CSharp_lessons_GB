// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// string num1str = Console.ReadLine();
// int num = Convert.ToInt32(num1str);

using System.Transactions;

Console.Write("Enter the first number: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if(num1 == num2 * num2)
{
    Console.WriteLine("The first number is a square of the second");
}
else
{
    Console.WriteLine("The first number is NOT a square of the second");
}