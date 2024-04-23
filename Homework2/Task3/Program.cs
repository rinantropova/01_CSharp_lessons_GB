Console.Write("Type a new number from array [10, 99]: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int firstDigit = num % 10;
    int secondDigit = num /10;

    // int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    // Console.WriteLine(maxDigit);

    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"The biggest digit is: {firstDigit}");
    }
    else
    {
        Console.WriteLine($"The biggest digit is: {secondDigit}");
    }
}
else
{
    Console.WriteLine("Incorrect input!");
}
