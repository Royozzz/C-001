// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// try
// {
//     Console.Write("введите координату х ");
//     int x = int.Parse(Console.ReadLine());
//     Console.Write("введите координату y ");
//     int y = int.Parse(Console.ReadLine());
//     int res;
//     if (x > 0 && y > 0) res = 1;
//     else if (x > 0 && y < 0) res = 2;
//     else if (x < 0 && y < 0) res = 3;
//     else if (x < 0 && y > 0) res = 4;
//     else res = 0;

//     if (res != 0) Console.WriteLine($"это четверть с номером {res}");
//     else Console.WriteLine("точка лежит на осях");
// }
// catch
// {
//     Console.WriteLine($"Введите целое число");
// }

// Задача 18: Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

// string Getxy()
// {
//     Console.WriteLine("Задайте номер четверти ");
//     int res = int.Parse(Console.ReadLine());

//     if (res == 1) return "точка лежит на осях x , y";

//     else if (res == 2) return "точка лежит на осях -x , y";

//     else if (res == 3) return "точка лежит на осях -x , -y";

//     else if (res == 4) return "точка лежит на осях x , -y";

// }
// try
// {
//     Console.WriteLine(Getxy());
// }

// catch
// {
//     Console.WriteLine($"Введите значение от 1 до 4 ");
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//void Getab()
//{

// Console.Write("введите координату a точке x ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("введите координату a точке y ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("введите координату b точке x ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("введите координату b точке y ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double res;
// res = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));

// Console.WriteLine($"Расстояние между точек равно {res}");
//}
//void Getab();



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// 1 вариант
// Console.Write("Введите любое число");
// int N = int.Parse(Console.ReadLine());

// Console.WriteLine("Число" + "\t" + "Квадрат");
// for (int i = 1; i <= N; i++)
//     Console.WriteLine(i + "\t" + i * i);

// Console.ReadLine();

// 2 вариант

// string numdersKV()
//  {
//     Console.Write("Введите положительное число ");
//             int N = Convert.ToInt32(Console.ReadLine());
//             int i=1;
//             string res = String.Empty;   //пустая строка
//             while (i <= N)
//             {
//                 res = res + i*i+", ";
//                 i=i+1;

//             }
//     return res;
//  }

//  Console.WriteLine(numdersKV());

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.Write("Введите число : ");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine($"Квадрат \t Число");
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine($"{i} \t \t  {i * i * i}");
// }





