// Array in function, changing each even element to 0

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 2, 4, 6, 7, 8, 8, 9, 10, 11 };
ZeroEvenElements(array);
PrintArray(array);
