// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void getAr()
{
    Console.WriteLine("Введите число элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int i = 0;
    while (i < n)
    {
        Console.Write("Введите элемент массива : ");
        array[i] = int.Parse(Console.ReadLine());
        Console.WriteLine();
        i++;
    }

    for (i = 0; i < n; i = i + 1)
        Console.Write($"{array[i]}  ");
}
getAr();