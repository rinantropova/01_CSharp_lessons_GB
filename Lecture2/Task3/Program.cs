//int n = 10;
int[] array = {2, 4, 5, 6, 45, 34, 22, 1, 7, 78};
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}