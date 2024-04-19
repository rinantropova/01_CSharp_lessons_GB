// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Write("Enter 3-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) // if (num > 99 && num < 1000)
{
int firstDigit = num / 100; // 456 / 100 = 4,56
int lastDigit = num %  10; // 456 % 10 = 6

int sum = firstDigit + lastDigit;
Console.WriteLine($"Sum of the first and last digits of {num}:  {sum}");
}
else
{
    Console.Write("Incorrect number");
}