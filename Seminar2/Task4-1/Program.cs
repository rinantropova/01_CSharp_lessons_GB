//Third from the left

Console.Write("Type a new positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 || num <= -100)
{
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
    int lastDigit = num % 10;
    Console.WriteLine($"The result is: {lastDigit}");
}
else
{
    Console.WriteLine("There is no third digit in your number!");
}