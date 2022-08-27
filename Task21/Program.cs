// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

string getDist3D()
{

    Console.Write("введите координату x точке А : ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("введите координату y точке А : ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("введите координату z точке А : ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("введите координату x точке B : ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("введите координату y точке B : ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("введите координату z точке B : ");
    double z2 = Convert.ToDouble(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    return $"Расстояние между точеками равно {result:f2}";
}
try
{
    Console.WriteLine(getDist3D());
}
catch
{
    Console.WriteLine("Вводите только целые числа");
}
