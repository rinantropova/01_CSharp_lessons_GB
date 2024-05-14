// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
             Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int CountDividedByAEndsWithB(int[] array, int aLast, int bDiv)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 10 == aLast && array[i] % bDiv == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Set up the size of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(n, 1, 100);
PrintArray(arr);
int result = CountDividedByAEndsWithB(arr, 2, 6);
Console.Write($" => {result}");