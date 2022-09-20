// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int Sum(int n, int m)
{
    if (n == m + 1) return 0;
    return n + Sum(n + 1, m);
}

Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(n, m));