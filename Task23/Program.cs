// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string getCube()
{
    Console.Write("Введите число : ");
    int N = Convert.ToInt32(Console.ReadLine());
    string result = String.Empty;
    for (int i = 1; i <= N; i++)
    {
        result += i * i * i + " ";
    }
    return result;
}

try
{
    Console.WriteLine(getCube());
}

catch
{
    Console.WriteLine($"Введите Число! ");
}
