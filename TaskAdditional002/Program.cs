// Задача 19 HARD - необязательная

// Напишите программу, которая принимает на вход число любой размерности и проверяет, 
// является ли оно палиндромом.

Console.Write("Введите число : ");
string n = Convert.ToString(Console.ReadLine());

int[] FillArray()
{
    int[] arr = new int[n.Length];
    for (int i = 0; i < n.Length; i++)
    {
        arr[i] = int.Parse(n[i].ToString());

        Console.Write($"{arr[i]}  ");



    }
    Console.WriteLine();
    return arr;

}

void getPol()
{
    int[] result = FillArray();
    int size = result.Length / 2;
    for (int i = 0; i < result.Length / 2; ++i)
    {
        if (result[i] == result[result.Length - 1 - i])
        {
            if (size == i + 1)
            {
                Console.WriteLine($" Число является полиндромом");
            }

        }
        else Console.WriteLine($" Число  полиндромом Не является");

    }
}
getPol();




