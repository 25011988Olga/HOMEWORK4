﻿
int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join( ", ",array)}]");



