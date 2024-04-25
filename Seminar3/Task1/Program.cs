Console.Write("Type a new positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

// int num = 10;
int[] array = {2, 4, 5, 6, 45, 34, 22, 1, 7, 78};

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