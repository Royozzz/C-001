// using System;

// namespace lesson1_morning
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//                                         Разворот массива
//          int [] Array (int yyy)
//             {
//             int[] array = new int[yyy];    //Создали массив заданной размерности
//             for (int i =0; i < yyy; i++) // Заполняем массив случайными цифрами стр 9-11
//             {
//                 array [i] = new Random().Next(1, 99);
//             }
//             return array;
//             }
//         void VivodMassiva()                 //Красиво выводим массив строки 13-18
//             {
//                 Console.Write("[");                     
//             for (int i = 0; i < res.Length - 1; ++i)
//             {
//                 Console.Write(res[i] + " ");
//             }
//             Console.WriteLine(res[res.Length - 1] + "] ");
//             }
//         void ChangeArray(int[] array )
//             {
//                 int buf;
//                 for (int i=0; i<n/2;i++)
//                     {
//                         buf = array[i];
//                         array[i] = array [n-1-i];
//                         array [n-1-i] = buf;
//                     }
//             }

//         try    
//             {
//             Console.Write("Введите размерность массива ");
//             int n = Convert.ToInt32(Console.ReadLine());
//             int [] res = Array ();
//             VivodMassiva();
//             ChangeArray(res);
//             VivodMassiva();
//             }
//         catch
//             {
//                 Console.WriteLine("Что-то пошло не так!");
//             }       int [] Array (int yyy)
//             {
//             int[] array = new int[yyy];    //Создали массив заданной размерности
//             for (int i =0; i < yyy; i++) // Заполняем массив случайными цифрами стр 9-11
//             {
//                 array [i] = new Random().Next(1, 99);
//             }
//             return array;
//             }
//         void VivodMassiva()                 //Красиво выводим массив строки 13-18
//             {
//                 Console.Write("[");                     
//             for (int i = 0; i < res.Length - 1; ++i)
//             {
//                 Console.Write(res[i] + " ");
//             }
//             Console.WriteLine(res[res.Length - 1] + "] ");
//             }
//         void ChangeArray(int[] array )
//             {
//                 int buf;
//                 for (int i=0; i<n/2;i++)
//                     {
//                         buf = array[i];
//                         array[i] = array [n-1-i];
//                         array [n-1-i] = buf;
//                     }
//             }

//         try    
//             {
//             Console.Write("Введите размерность массива ");
//             int n = Convert.ToInt32(Console.ReadLine());
//             int [] res = Array ();
//             VivodMassiva();
//             ChangeArray(res);
//             VivodMassiva();
//             }
//         catch
//             {
//                 Console.WriteLine("Что-то пошло не так!");
//             }
//         }
//     }
// }
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон


// string ChechTriangle()
// {
//     string result = "";
//     Console.WriteLine("Введите длинну стороны A ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите длинну стороны B ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите длинну стороны C");
//     int c = Convert.ToInt32(Console.ReadLine());

//     if (a < b + c && b < a + c && c < a + b)
//     {
//         result = "Треугольник сущетвует";
//     }
//     else result = "Треугольник НЕ сущетвует";
//     return result;
// }
// Console.WriteLine(ChechTriangle());

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int GetNumber()
// {
//     Random rnd = new Random();
//     int randomNumber = rnd.Next(99);
//     int a = 0;
//     int b = 1;
//     while (randomNumber > 0)
//     {
//         a += (randomNumber % 2) * b;
//         randomNumber = randomNumber / 2;
//         b = b * 10;
//     }
//     return b;
// }
// System.Console.WriteLine(GetNumber());

// 2 вариант

//ДЕсятичое в двоичное
// Console.WriteLine("ВВедите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int i=0;
// int z=0;
// while (x!=0) 
// {
//     i = (i*10)+(x%2);
//     if (i==0)
//     {
//         z ++;
//     }
//     x = x/2;
// }
// x = i;
// i = 0;
// while (x >0)
// {
//     i = (i*10) + (x%10);
//     x = x/10;
// }

// while (z !=0 )
// {
//     i = i * 10;
//     z--;
// }
// Console.WriteLine($"{i}");

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// string Fib(int size)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         if (i == 0 || i == 1) res[i] = i;
//         else res[i] = res[i - 1] + res[i - 2];
//     }
//     string fibRes = string.Empty;
//     foreach (int item in res)
//     {
//         fibRes += item + " ";
//     }
//     return fibRes;
// }
// Console.Write("Введите число фибоначи: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Fib(numb));



