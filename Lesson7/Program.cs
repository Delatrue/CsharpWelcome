using System;
/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

// double[,] array2D = new double[3, 4];
// int rows = array2D.GetUpperBound(0) + 1;
// int columns = array2D.Length / rows;
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         var rand = new Random();
//         Console.Write($"{array2D[i, j] = Math.Round(rand.NextDouble() * 100, 1)} ");
//     }
//     Console.WriteLine();

// }




/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

// int[,] array = new int[3, 4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(10);
//         //Console.Write($"{array[i, j]} ");
//     }
//     //Console.WriteLine();
// }

// Console.Write($"Ввести позицию элемента: \n-> строка: ");
// int.TryParse(Console.ReadLine(), out int userRow);
// Console.Write($"-> столбец: ");
// int.TryParse(Console.ReadLine(), out int userColumn);
// if (userRow > array.GetLength(0) || userColumn > array.GetLength(1))
// {
//     Console.WriteLine("такого числа в массиве нет");
// }
// else
// {
//     Console.WriteLine($"{array[userRow, userColumn]}");
// }




/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write($"Среднее арифметическое каждого столбца: ");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sumAvg = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumAvg += array[i, j];
    }
    sumAvg /= array.GetLength(0);
    Console.Write($"{Math.Round(sumAvg, 1)}; ");
}
