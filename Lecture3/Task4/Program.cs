﻿// generation of random values

Random rnd = new Random();

int size = 1000;
int[] arr_int = new int[size];
int i = 0;
while(i < size)
{
    arr_int[i] = rnd.Next(1, 10);
    i++;
}

i = 0;
while(i < size)
{
    Console.Write($"{arr_int[i]} ");
    i++;
}
