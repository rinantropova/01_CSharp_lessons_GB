// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

Console.Write("Type a new number: ");
int num = Convert.ToInt32(Console.ReadLine());

// int num = 10;
int[] array = { -4, 3, 4, 1 };

// Console.Write(array.Length);
bool found = false;

for (int i = 0; i < array.Length; i++)
{
    if (num == array[i])
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine($"Yes, number {num} is in the array");
}
else
{
    Console.WriteLine($"No, number {num} is not in the array");
}