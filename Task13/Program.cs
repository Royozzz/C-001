// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


void PrintThirdNumber()
{

    Console.Write("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());
    int i = 1000;
    while (i < n)
    {
        n = n / 10;

        i++;
    }
    int Num = (n % 10);
    if (n < 1000 && n > 99)
    {

        Console.WriteLine($"Третья цифра числа {Num}");
    }
    else if (n < 100)
    {
        Console.WriteLine($"Третьей цифры НЕТ");
    }
}
PrintThirdNumber();