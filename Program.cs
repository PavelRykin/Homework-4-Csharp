﻿/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Random number = new Random();
    array[i] = number.Next(0, 1000);
    Console.Write(array[i] + " ");
}




