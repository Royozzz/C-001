// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);

        Console.Write($"{array[i]} ");
    }
    return array;
}
int getSum()
{
    int[] mas = FillArray();
    int sum = 0;
    for (int i = 1; i < mas.Length; i += 2)
    {
        sum += mas[i];

    }
    Console.WriteLine();
    return sum;

}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {getSum()}");