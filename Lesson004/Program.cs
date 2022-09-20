// int[] array = { 5, 6, 8, 11, 77, 55, 22 };
// for (int i = 0; i < array.Length; i++)
// {
//     if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//     else Console.WriteLine($"{array[i]}");
// }

// Задача 30: Напишите программу, которая выводит массив из N элементов, 
// заполненный случайными целыми числами. N - целое число и задается с клавиатуры.

// void ArrayPrint()
// {
//     Console.Write("Введите число N: ");
//     int N = int.Parse(Console.ReadLine());
//     int[] array = new int[N];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//         if (i != N - 1) Console.Write($"{array[i]}, ");
//         else Console.WriteLine($"{array[i]}");
//     }
// }

// try
// {
//     ArrayPrint();
// }
// catch
// {
//     Console.WriteLine("Неверный вормат ввода!");
// }

// Написать программу, где уже реализовано заполнение массива случайными числами.
//  И в этом массиве надо найти максимум и его индекс, минимум и его индекс, 
//  среднее арифметическое всех элементов массива. Всё это обернуть в функции.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]}, ");

}
Console.WriteLine();

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
}
Console.Write($"Среднее арифметическое {sum / N} ");


int maxInd = 0;
int minInd = 0;
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= max)
    {
        max = array[i];
        maxInd = i;
    }
    else if (array[i] <= min)
    {
        min = array[i];
        minInd = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Максимальное значение  {max} ");
Console.WriteLine($"Максимальный индекс  {maxInd} ");
Console.WriteLine($"Минимальное значение  {min} ");
Console.WriteLine($"Минимальный индекс  {minInd} ");