Console.Write("Enter new positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = num /100;
int lastDigit = num % 10;

Console.WriteLine($"The number is: {firstDigit}{lastDigit}");

