﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void WeekNumber()
{

    Console.WriteLine("Введите число от 1 до 7 ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n == 6 || n == 7)
    {
        Console.WriteLine($"Выходной день");

    }
    else if (n > 7 || n < 1)
    {
        Console.WriteLine($"ВВЕДИТЕ ЧИСЛО от 1 до 7");
    }
    else
    {
        Console.WriteLine($"Рабочий день");
    }
}
WeekNumber();