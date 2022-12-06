/* Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет */

using static System.Console;

WriteLine("Введите размеры массива (кол-во строк и столбцов): ");
int m = Convert.ToInt32(ReadLine());
int n = Convert.ToInt32(ReadLine());

double[,] GetArray(int rows, int cols)
{
    double[,] arr = new double[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = new Random().Next(-10,10);
        }
    }

    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]}, ");
        }
        WriteLine();
    }
}

double [,] array = GetArray(m, n);
PrintArray(array);

WriteLine("Введите искомое число: ");
double x = Convert.ToInt32(ReadLine());

void FindNumber (double [,] arr, double z)
{
    int mistake = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == z) WriteLine($"Искомое число находится на позиции ({i},{j})");
            else mistake++;
        }
    }

    if (mistake == arr.Length) WriteLine($"Такого числа в массиве нет");
}

FindNumber(array, x);