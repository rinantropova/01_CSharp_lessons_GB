int n = 10;
int[] array = new int[n];
int i = 0;

while (i <array.Length)
{
    array[i] = i + 1;
    // Console.Write(array[i] + ' ');
    Console.Write($"{array[i]} ");
    i++;
}
