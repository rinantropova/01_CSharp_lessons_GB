// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]



// using Internal;

// void endlessInput()
// {
//    List<int> addedNumbers = new List<int>();
//    while(true)
//     {
//         Console.WriteLine("Input number ");
//         int n = Convert.ToInt32(Console.ReadLine());
//     }
//     addedNumbers.Add(n);
//     Console.Write($"{addedNumbers} ");
// }



void endlessList()
{
    while(true)
    {
        Console.WriteLine("Input number or 'q' to stop the program: ");
        string input = Console.ReadLine();
        if (input.ToLower() == "q")
        {
            Console.Write("[STOP]");
        }
        if (int.TryParse(input, out int number))
        {
            if (digitSumEven(number))
            {
                Console.Write("[STOP]");
                break;
            }
        }     
    }
}

bool digitSumEven(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum % 2 == 0;
}

// bool qSymbolStop(int n)
// {
//     if (n == 113)
//     {
//         Console.Write("q ");
//         Console.Write("[STOP]");
//         return true;
//     }
//     return false;
// }


endlessList();