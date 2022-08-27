// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

void FindPol()
{
    Console.WriteLine("Введите пятизначное число");
    int n = Convert.ToInt32(Console.ReadLine());

    int a = n / 10000;
    int b = (n % 10000) / 1000;
    int c = (n % 1000) / 100;
    int d = (n % 100) / 10;
    int e = n % 10;
    if (n > 99999 || n <= 0)
    {
        Console.WriteLine($"Введите пятизначное число!!!");
    }
    else if (a == e && b == d)
    {
        Console.WriteLine($"Число {n} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {n} палиндромом НЕ является");
    }

}

FindPol();



