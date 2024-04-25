// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]


Console.Write("Type a new positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int[] array = new int[3];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num % 10;
        num = num / 10;
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
else
{
    Console.WriteLine("Incorrect input!");
}