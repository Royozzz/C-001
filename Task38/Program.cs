// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] FillArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99);

        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;

}
int difference()
{
    int[] arrayDiff = FillArray();
    int min = 0;
    int max = 0;
    int deff = 0;
    for (int i = 0; i < arrayDiff.Length; i++)
    {
        if (arrayDiff[i] > arrayDiff[max])
        {
            max = i;
        }
        else if (arrayDiff[i] < arrayDiff[min])
        {
            min = i;
        }

    }
    deff = arrayDiff[max] - arrayDiff[min];
    return deff;
}
Console.WriteLine($"Разницу между максимальным и минимальным элементами массива, равна {difference()}");