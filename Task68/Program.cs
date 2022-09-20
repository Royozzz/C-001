// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29



int GetA(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n != 0 && m == 0) return GetA(n - 1, 1);
    else if (n > 0 && m > 0) return GetA(n - 1, GetA(n, m - 1));
    return GetA(n, m);
}


Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetA(n, m));