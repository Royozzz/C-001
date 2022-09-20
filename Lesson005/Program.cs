// Создайте массив положительных и отридцательных чисел и 
// найдите в начале сумму положительных затем сумму отридцательных. 
// int[] FillArray(int size)
//             {
//             int[]array = new int[size];
//             for (int i = 0; i < array.Length; i++)
//                 {
//                     array[i] = new Random().Next(-9, 10);
//                     if (i!=array.Length-1) Console.Write($"{array[i]}, ");
//                     else Console.WriteLine($"{array[i]}");
//                 }
//             return array;
//             }

//         int[] mas=FillArray(7);

//         int[] FindSums(int[] array)
//             {
//             int sum_p=0;
//             int sum_n=0;
//             foreach (int item in array)
//                 {
//                   if (item>0)   sum_p+=item;
//                   else sum_n+=item;
//                 }

//             int[] rrr={sum_n,sum_p};
//             return rrr;
//             }

//         int[] results=FindSums(mas);

//         Console.WriteLine($"Сумма отрицательных чисел равна {results[0]}");
//         Console.WriteLine($"Сумма положительных чисел равна {results[1]}");

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] array = new int[4];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);

//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// int[] array2 = array;
// for (int j = 0; j < array2.Length; j++)
// {
//     array2[j] *= -1;

//     Console.Write($"{array[j]} ");
// }

// Задача 33: Задайте массив.Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// - 3; массив[6, 7, 19, 345, 3]->да

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.WriteLine($"{array[i]}");
//     }
//     return array;
// }

// int[] mas = FillArray(10);
// Console.WriteLine("Введите число для поиска ");
// int x = Convert.ToInt32(Console.ReadLine());
// bool find = false;
// foreach (int item in mas)
// {
//     if (item == x)
//     {
//         find = true;
//         break;
//     }

// }

// if (find) Console.WriteLine("ДА");
// else Console.WriteLine("НЕТ");


// Задача 35: Задайте одномерный массив из 15 случайных чисел от -50 до 100.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5  элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// 1 вариант
// int[] array = new int[15];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-50, 101);

//     Console.Write($"{array[i]} ");
// }

// Console.WriteLine();
// int[] array2 = array;
// int count = 0;
// for (int j = 0; j < array2.Length; j++)
// {

//     if (array2[j] >= 10 || array2[j] <= 99)


//         count++;


// }
// Console.Write($"{count} ");

// 2 вариант

// int[] FillArray()
//             {
//             int[]array = new int[15];
//             for (int i = 0; i < array.Length; i++)
//                 {
//                     array[i] = new Random().Next(-50, 101);
//                     if (i!=array.Length-1) Console.Write($"{array[i]}, ");
//                     else Console.WriteLine($"{array[i]}");
//                 }
//             return array;
//             }
//     int[] mas=FillArray();
//     int count = 0;
//         foreach (int item in mas)
//         {
//             if (item>=10 && item<=99) 
//             {
//                 count++;
//             }

//         }

//          Console.WriteLine(count);

// 3 вариант

// int countElement(int[] array)
// {
//     int count = 0;
//     foreach (int item in array)
//     {
//         if (item >= 10 && item <= 99) count++;
//     }
//     return count;
// }


// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];    //Создали массив заданной размерности

// for (int i = 0; i < N; ++i)  // Заполняем массив случайными числами от 1 до 9
// {
//     array[i] = new Random().Next(1, 10);
// }

// Console.Write("[");                     //Красиво выводим массив
// for (int i = 0; i < N - 1; ++i)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine(array[N - 1] + "]");

// int[] result = new int[N / 2 + N % 2]; //Создаём массив для хранения результата 
//                                        //(При чётном размер будет равен размеру изначального массива, делённому на 2,
//                                        //при нечётном, к этому будет добавлена единица.)

// for (int i = 0; i < array.Length / 2; ++i) //Фиксируем результаты произведений всех пар элементов
// {
//     result[i] = array[i] * array[array.Length - 1 - i];
// }

// if (array.Length % 2 == 1)  // Фиксируем оставшийся элемент при нечётном количестве элементов
// {
//     result[array.Length / 2] = array[array.Length / 2];
// }

// for (int i = 0; i < result.Length - 1; ++i) //Выводим на экран результирующий массив
// {
//     Console.Write(result[i] + " ");
// }
// Console.WriteLine(result[result.Length - 1]);

// Двумерные массивы и рекурсии.

// string[,] table = new string[2, 5];

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     System.Console.WriteLine();
// }

// Заполнение матрицы случайными числами

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);//[1; 10)
//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// Закрашивание области

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);

// Рекурсия

// Вычисление факториала

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6

// 2 вариант через double

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Вычисление чисел Фибоначчи

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}