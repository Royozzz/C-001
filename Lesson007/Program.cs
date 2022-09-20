// Task 46

// Задайте двумерный массив размером m*n ,
// заполненный случайными числами.
// m= 3 , n= 4,
// 1  4  8  19
// 5 -2 33  -2
// 77 3  8   1 



// void PrintArray(int[,] GetArray)
// {

//     for (int i = 0; i < GetArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < GetArray.GetLength(1); j++)
//         {
//             GetArray[i, j] = new Random().Next(1, 100);
//             Console.Write($"{GetArray[i, j]}  ");
//         }

//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите колличество строк : ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов : ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// PrintArray(array);


// Задача 48: Задайте двумерный массив размера m на n,
//  каждый элемент в массиве находится по формуле: Aₘₙ = m + n.Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] GetArray()
// {
//     System.Console.WriteLine("Введите колличество строк : ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите колличество столбцов : ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }

//         Console.WriteLine();
//     }
// }
// PrintArray(GetArray());

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int[,] GetArray()
// {

//     int m = 3;
//     int n = 4;
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);


//             Console.Write(array[i, j] + "\t");

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 != 0 && j % 2 != 0)
//             {
//                 array[i, j] *= array[i, j];
//             }
//             Console.Write(array[i, j] + "\t");
//         }

//         Console.WriteLine();
//     }
// }
// PrintArray(GetArray());

// Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

// int[,] GetArray()
// {

//     int m = 3;
//     int n = 4;
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);


//             Console.Write(array[i, j] + "\t");

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {


//             int minPosition = array[i, j]; //рабочий элемент
//             int temporary = array[i, j]; //замена позиций
//             array[i, j] = minPosition;
//             minPosition = temporary;
//             Console.Write(array[i, j] + "\t");
//         }

//         Console.WriteLine();
//     }
// }
// PrintArray(GetArray());


// Сортировка одгомерного  массива

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array) //вывод массива на экран
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine(); //пустая сторока
// }

// void SelectionSort(int[] array) //сортировка массива
// {
//     for (int i = 0; i < array.Length - 1; i++) //перебор элементов массива
//     {
//         int minPosition = i; //рабочий элемент

//         for (int j = i + 1; j < array.Length; j++) //max элемент
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i]; //замена позиций
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

