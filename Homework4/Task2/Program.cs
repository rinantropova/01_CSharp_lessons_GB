// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
// [344 452 341 125] => 2


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        int randomNumber = rnd.Next(min, max+1);
        while(randomNumber < 100 || randomNumber > 999)
        {
            randomNumber = rnd.Next(min, max + 1);
        }
        array[i] = randomNumber;
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

int CountEvenNum(int[] array)
{
    int count = 0;
// release
    for (int i = 0; i < array.Length; i++)
    {
        if(IsEven(array[i]))
        {
            count++;
        }
    }
    return count;
}

bool IsEven(int num)
{
    if (num % 2 == 0)
    {
        return true;
    
    }
    return false;
}

int[] arr = CreateArrayRndInt(10, 88, 1001);
PrintArray(arr);

int countEvenNum = CountEvenNum(arr);
Console.Write($" => {countEvenNum}");