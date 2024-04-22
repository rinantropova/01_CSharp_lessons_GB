Console.Write("Enter new 3-digits positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
int firstDigit = num /100;
int lastDigit = num % 10;

//Console.WriteLine($"The number is: {firstDigit}{lastDigit}");
int result = firstDigit * 10 + lastDigit;

Console.WriteLine($"The result is {result}");
}
else
{
    Console.WriteLine("Incorrect input!");
}