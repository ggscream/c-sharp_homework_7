/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using static System.Console;

WriteLine("Введите размеры массива (кол-во строк и столбцов): ");
int m = Convert.ToInt32(ReadLine());
int n = Convert.ToInt32(ReadLine());

int [,] GetArray(int rows, int cols)
{
    int [,] arr = new int [rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = new Random().Next(1000);
        }
    }

    return arr;
}

void PrintArray (int [,] arr)
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

void FindAverage (int [,] arr)
{
    double average = 0;
    
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        WriteLine(sum);
        average = sum / arr.GetLength(0);
        WriteLine($"Среднее арифметическое {i+1} столбца массива равно {average}");
    }
}

int [,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
FindAverage(array);