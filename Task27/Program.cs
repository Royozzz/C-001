// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11

// 82 -> 10

// 9012 -> 12



int getSum()
{
    Console.Write("Введите число : ");
    string n = Convert.ToString(Console.ReadLine());

    int[] arr = new int[n.Length];
    int sum = 0;
    for (int i = 0; i < n.Length; i++)
    {
        arr[i] = int.Parse(n[i].ToString());

        sum = sum + arr[i];


    }
    return sum;
}
Console.WriteLine(getSum());