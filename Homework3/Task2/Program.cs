int[] array = new int[10] {22, 45, 12, 5, 6, 120, 55, 6, 78, 23};
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
