Console.Write("Enter new 3-digits positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
int thirdDigit = num % 10;
int secondDigit = num /10 % 10;
// double raised = Math.Pow(secondDigit, thirdDigit);

int result = secondDigit;
int count = 1;

while (count < thirdDigit)
{
    result = result * secondDigit; // result *= secondDigit;
    count++;
}
Console.WriteLine($"The result is: {result}");
}
else
{
    Console.WriteLine("Incorrect input!");
}