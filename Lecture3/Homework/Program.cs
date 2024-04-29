
void FillArray(int[] array)
{
   
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
}

void PrintArray(int[] array)
{
        for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} " );
    }
}

int GetSumOfElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

int GetProductOfElements(int[] array)
{
    int product = 1;
    for(int i = 0; i < array.Length; i++)
    {
        product *= array[i];
    }
    return product;
}

int n = 10;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.Write(Environment.NewLine);
Console.WriteLine(sum);
Console.WriteLine(product);
