﻿// необязательная задача.

// В институте биоинформатики по офису передвигается робот. 
// Недавно студенты из группы программистов написали для него программу,
// по которой робот, когда заходит в комнату, 
// считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное),
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист", 
// для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи,
// как минимум до 1000 человек.

Console.WriteLine("Введите число программистов");
void Prog()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x % 10 < 2 && x % 10 > 0)
    {
        Console.WriteLine($"{x} Программист");
    }
    else if (x % 10 > 1 && x % 10 < 5)
    {
        Console.WriteLine($"{x} Программиста");
    }
    else
    {
        Console.WriteLine($"{x} Программистов");
    }
}
Prog();