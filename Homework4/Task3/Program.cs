// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]




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
    Console.Write("] ");
}

void ReversedArrayOrder(int[] array)
{
    int firstIndex = 0;
    int lastIndex = array.Length - 1;

    while(firstIndex < lastIndex)
    {
        int temp = array[firstIndex];
        array[firstIndex] = array[lastIndex];
        array[lastIndex] = temp;
        firstIndex++;
        lastIndex--;
    }
    
}

int[] arr = CreateArrayRndInt(7, 1, 100);
PrintArray(arr);
ReversedArrayOrder(arr);
Console.WriteLine($"Reversed array is: ");
foreach (int num in arr)
{
    Console.Write(num + " ");
}

