//Third from the end

Console.Write("Enter a new positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int thirdDigit = num / 100;

if (thirdDigit >= 10)
{
    int finalThird = thirdDigit % 10;
    Console.WriteLine(finalThird); 
}
if (thirdDigit < 10 && thirdDigit > 0)
{
    Console.WriteLine(thirdDigit);
}
else
{
    Console.WriteLine("There is no third digit in your number!");
}
