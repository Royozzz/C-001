// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.



// int[,] FillMatrix(int row, int col)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }

//     }
//     return matrix;
// }
// //вывод массива на консоль
// void PrintMatrix(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             System.Console.Write(table[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// int[,] ChangeRows(int[,] matrix)
// {
//     int temp;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;

//     }
//     return matrix;

// }
// try
// {
//     Console.WriteLine("Введите число строк массива: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int[,] matrix = FillMatrix(m, n);
//     System.Console.WriteLine("Исходный массив: ");
//     PrintMatrix(matrix);
//     System.Console.WriteLine();
//     System.Console.WriteLine("Новый массив: ");
//     PrintMatrix(ChangeRows(matrix));


// }
// catch
// {

//     System.Console.WriteLine("Oшибка");
// }

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] FillMatrix(int row, int col)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }

//     }
//     return matrix;
// }
// //вывод массива на консоль
// void PrintMatrix(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             System.Console.Write(table[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// int[,] TurnMatrix(int[,] matrix)
// {
//     int row = matrix.GetLength(0);
//     int col = matrix.GetLength(1);
//     int[,] turnedMatrix = new int[col, row];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             turnedMatrix[j, i] = matrix[i, j];
//         }
//     }
//     return turnedMatrix;
// }
// try
// {
//     Console.WriteLine("Введите число строк массива: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int[,] matrix = FillMatrix(m, n);
//     System.Console.WriteLine("Исходный массив: ");
//     PrintMatrix(matrix);
//     System.Console.WriteLine();
//     if (m == n)
//     {
//         TurnMatrix(matrix);
//         PrintMatrix(TurnMatrix(matrix));
//     }
//     else System.Console.WriteLine("Массив {0}x{1} повернуть нельзя ", m, n);


// }
// catch
// {
//     System.Console.WriteLine("Oшибка");
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

