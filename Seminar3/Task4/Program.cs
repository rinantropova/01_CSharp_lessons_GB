// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

// My Solution:
// Console.Write("Type a new positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
//     int[] array = new int[3];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = num % 10;
//         num = num / 10;
//     }
//     // Console.WriteLine($"[{string.Join(", ", array)}]");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// else
// {
//     Console.WriteLine("Incorrect input!");
// }



// Seminar's stupid solution:
int num;
Console.Write("Type a number: ");
num = Convert.ToInt32(Console.ReadLine());
int numCopy = num;
int count = 0;
while (numCopy !=0)
{
    numCopy /= 10;
    count++;
}


int[] arr = new int[count];
int index = 0;

while (num != 0)
{
    arr[index] = num % 10;
    num /= 10;
    index++;
}
Console.Write("[ ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.Write("]");