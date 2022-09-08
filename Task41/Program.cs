// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int GetNumber()
{
    Console.WriteLine("Введите число элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int i = 0;
    int count = 0;
    while (i < n)
    {
        Console.Write("Введите  число : ");
        array[i] = int.Parse(Console.ReadLine());
        Console.WriteLine();
        i++;
    }

    for (i = 0; i < n; i = i + 1)
        if (array[i] > 0)
        {
            count++;
        }
    return count;
}

Console.WriteLine($"Пользователь ввёл {GetNumber()} чисел больше 0");