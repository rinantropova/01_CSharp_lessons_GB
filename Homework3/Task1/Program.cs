int[] array = new int[10] {22, 45, 12, 5, 6, 123, 55, 6, 73, 23};
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }
}
Console.WriteLine(count);
