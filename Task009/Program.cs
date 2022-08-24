// void PrintMaxDigit()
// {
//     int x = new Random().Next(10, 99);
//     Console.WriteLine(x);
//     if (x % 10 > x / 10)
//     {
//         Console.WriteLine($"Второе число {x % 10} больше чем первое {x / 10}");
//     }
//     else
//     {
//         Console.WriteLine($"Первое число {x / 10} больше чем второе {x % 10}");
//     }
// }
// PrintMaxDigit();
// PrintMaxDigit();

// void PrintMaxDigit()
// {
//     int x = new Random().Next(10, 100);
//     Console.WriteLine($"сгенерировалось случайное число {x}");
//     int x1 = x / 10;
//     int x2 = x % 10;
//     if (x1 > x2) Console.WriteLine(x1);
//     else Console.WriteLine(x2);
// }

//PrintMaxDigit();
// void PrintMaxDigitArg(int xx)
// {

//     // Console.WriteLine($"сгенерировалось случайное число {xx}");
//     int x1 = xx / 10;
//     int x2 = xx % 10;
//     if (x1 > x2) Console.WriteLine(x1);
//     else Console.WriteLine(x2);
// }

// PrintMaxDigitArg(int.Parse(Console.ReadLine()));

// void PrintMaxDigit()
// {
//     int x = new Random().Next(100, 1000);
//     Console.WriteLine($"сгенерировалось случайное число {x}");
//     int a = x / 100;
//     int b = (x % 100) / 10;
//     int c = x % 10;

//     Console.WriteLine($"{a}{c}");
// }
// PrintMaxDigit();

// void PrintMaxDigit()
// {
//     Random rnd = new Random();

//     int value = rnd.Next();
//     Console.WriteLine(value);
//     int i = Convert.ToInt32(Math.Log2(value));

//     Console.WriteLine(i);
// }
// PrintMaxDigit();

// string PrintMaxDigitF(int x)
// {
//     //int x = new Random().Next(100,1000);
//     //Console.WriteLine($"сгенерировалось случайное число {x}");
//     int x1 = x / 100;
//     int x3 = x % 10;
//     return $"{x1}{x3}";
//     //
// }
// int x = new Random().Next(100, 1000);
// Console.WriteLine($"сгенерировалось случайное число {x}");
// PrintMaxDigitF(x);

// void PrintMaxDigit()
// {
//     Console.Write("Введите первое число ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите второе число ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     if (a > b)
//     {
//         Console.WriteLine($"Второе число не кратно первому ,остаток {a % b}");
//     }
//     else if (b % a == 0)
//     {

//         Console.WriteLine($"Второе число кратно первому");
//     }
//     else
//     {
//         Console.WriteLine($"Второе число не кратно первому ,остаток {a % b}");
//     }
// }
// PrintMaxDigit();