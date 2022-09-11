// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] FillArray()
{


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

void GetAnswer()
{

    int[,] array = FillArray();

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        double count = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
            count++;
        }

        Console.Write($"{sum / count:f1}\t");
    }
}
GetAnswer();