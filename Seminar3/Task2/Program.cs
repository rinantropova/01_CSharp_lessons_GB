int[] array = {-10, 9, -8, 7, -6, 5, -4, 3, -2, 1};

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
    Console.Write($"{array[i]} ");
}

