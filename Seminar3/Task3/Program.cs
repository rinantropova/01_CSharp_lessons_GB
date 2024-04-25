// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


int[] array = {2, 3, 5, 56, 32, 11, 6, 4, 12};
int size = array.Length / 2;
int[] newArr = new int[size];

// Console.Write(newArr.Length);

int i = 0;
int j = array.Length - 1;

for (int e = 0; e < newArr.Length; e++)
{
    newArr[e] = array[i] * array[j];
    i++;
    j--;
}
   
// newArr[1] = array[i] * array[j];
// i++;
// j--;
// newArr[2] = array[i] * array[j];
// i++;
// j--;
// newArr[3] = array[i] * array[j];

// Array.ForEach(newArr, Console.WriteLine);
Console.WriteLine($"[{string.Join(", ", newArr)}]");