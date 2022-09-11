﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию в строке : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию в столбце : ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] FillArray()
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]}\t");


        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

void FindElem()
{
    int[,] array = FillArray();

    if (m < x || n < y)
    {
        Console.WriteLine($"Такого элемента нет в массиве");
    }

    else
        Console.WriteLine($"Значение элемента равно {array[x - 1, y - 1]}");

}
FindElem();