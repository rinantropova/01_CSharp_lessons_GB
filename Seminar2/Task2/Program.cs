Console.Write("Enter new 3-digits positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int thirdDigit = num % 10;
int secondDigit = (num /10) % 10;
double raised = Math.Pow(secondDigit, thirdDigit);

Console.WriteLine($"The result is: {raised}");
