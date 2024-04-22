Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    int remainder = num1 % num2;
    Console.WriteLine($"No, the remainder is: {remainder}"); 
}