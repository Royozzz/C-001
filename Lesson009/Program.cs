// Вычисление сумму натуральных чисел от 1 до N.

// Обычное решение
// int SummaLoop(int N) //5
// {
//     int sum = 0; 
//     while (N > 0) //5,4,3,2,1
//     {
//         sum += N;  //5,9,12,14,15
//         N--;       //4,3,2,1,0
//     }
//     return sum;    // 15
// }

// Console.WriteLine(SummaLoop(5));

// // Решение через рекурсию
// int SummaReg(int N) 
// {
//     if (N == 0) return 0;       //5,4,3,2,1,0
//     return N + SummaReg(N - 1); //9,12,14,15
// }
// System.Console.WriteLine(SummaReg(5));

// Задача 63: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// string SummaReg(int N)
// {
//     if (N == 0) return " ";
//     return SummaReg(N - 1) + " " + $"{N}";
// }
// System.Console.WriteLine(SummaReg(5));

// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// System.Console.WriteLine();

// string Sum(int N, int M)
// {
//     if (N == M) return $"{M} ";
//     return Sum(N - 1, M) + N + " ";
// }
// Console.WriteLine(Sum(15, 5));

// Задача 67: Напишите программу,
//  которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// int Sum(int count)
// {
//     if (count % 10 == 0 && count / 10 == 0) return 0;
//     return count % 10 + Sum(count / 10);
// }
// Console.WriteLine(Sum(n));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int SummaRec(int a, int b)
{
    if (b == 0) return 1;
    return a * SummaRec(a, b - 1);
}

Console.WriteLine(SummaRec(5, 3));