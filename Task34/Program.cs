// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);

        Console.Write($"{array[i]} ");
    }
    return array;
}

int getNum()
{
    int[] mas = FillArray(4);
    int count = 0;
    foreach (int item in mas)
    {
        if (item % 2 == 0)
        {
            count++;
        }

    }
    Console.WriteLine();
    return count;

}

Console.WriteLine($"Количество чётных чисел в массиве равно {getNum()}");