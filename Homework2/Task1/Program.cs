Console.Write("Type a new positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}