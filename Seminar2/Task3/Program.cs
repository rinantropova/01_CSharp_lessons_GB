Console.Write("Type the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Type the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num1 % num2;

if (remainder == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine($"No, the remainder is: {remainder}"); 
}