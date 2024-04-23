// Solution from GB
// Console.Write("Type a new positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 10)
// {
//     Console.WriteLine(num);
// }
// else
// {
//     while (num > 0)
//     {
//         int digit = num % 10;
//         num /= 10;
//         //num = num / 10;
        
//         if (num > 0)
//         {
//             Console.Write(digit + ", ");
//         }
//         else
//         {
//             Console.WriteLine(digit);
//         }
//     }
// }

// My solution
Console.Write("Type a new positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 0)
{
    int digit = num % 10;
    Console.Write(digit + ", ");
    num /= 10;
}