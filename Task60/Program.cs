// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckUnique(int[] array, int number)
{
    bool check = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            check = false;
        }
    }
    return check;
}



int[,,] FillArray(int rows, int columns, int depth)
{
    int[,,] cube = new int[rows, columns, depth];
    int[] array = new int[rows * columns * depth];
    int n = 0;
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                while (CheckUnique(array, cube[i, j, k]) == false)
                {
                    cube[i, j, k] = new Random().Next(10, 100);
                }
                array[n] = cube[i, j, k];
                n++;
            }

        }
    }
    return cube;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }

    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину: ");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] array = FillArray(row, column, depth);
PrintArray(array);