// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// My Solution:
int[] array = {2, 3, 5, 56, 32, 11, 6, 4, 12};
int size = array.Length / 2;
int[] newArr = new int[size];

int i = 0;
int j = array.Length - 1;

for (int e = 0; e < newArr.Length; e++)
{
    newArr[e] = array[i] * array[j];
    i++;
    j--;
}

for (int e = 0; e < newArr.Length; e++)
{
    Console.Write(newArr[e] + ", ");
}
// Array.ForEach(newArr, Console.WriteLine);
//Console.WriteLine($"[{string.Join(", ", newArr)}]");



// Seminar's solution:
int[] array = {2, 3, 5, 56, 32, 11, 6, 4};
int size = array.Length / 2;
int[] newArr = new int[size];

int left = 0;
int right = array.Length - 1;

while (left < right)
{
    newArr[left] = array[left] * array[right];
    left++;
    right--;
}
for (int i = 0; i < newArr.Length; i++)
{
    Console.Write(newArr[i] + ", ");
}
