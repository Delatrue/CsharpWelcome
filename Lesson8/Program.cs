using System.Collections.Generic;
using System.Linq;
/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

// int[,] array = new int[3, 4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(10);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     List<int> upDown = new List<int>();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         upDown.Add(array[i, j]);
//     }
//     upDown.Sort();
//     upDown.Reverse();
//     foreach (var item in upDown)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }




/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка */

// int[,] array = new int[4, 4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(10);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// int minSum = 0;
// int numOfRow = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//         sum += array[i, j];

//     }
//     //вывод номера строки и суммы
//     //Console.WriteLine($"сумма {i + 1} строки = {sum}");

//     if (minSum == 0)
//     {
//         minSum = sum;
//         numOfRow = i + 1;
//     }
//     else if (sum < minSum)
//     {
//         minSum = sum;
//         numOfRow = i + 1;
//     }
// }
// Console.WriteLine($"{numOfRow} строка");

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

// int[,] matrixA = new int[2, 2];
// int[,] matrixB = new int[2, 2];
// int[,] matrixC = new int[2, 2];

// for (int i = 0; i < matrixA.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixA.GetLength(1); j++)
//     {
//         matrixA[i, j] = new Random().Next(10);
//         Console.Write($"{matrixA[i, j]} ");
//     }
//     Console.Write("| ");
// }
// Console.WriteLine();
// for (int i = 0; i < matrixB.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixB.GetLength(1); j++)
//     {
//         matrixB[i, j] = new Random().Next(10);
//         Console.Write($"{matrixB[i, j]} ");
//     }
//     Console.Write("| ");
// }
// Console.WriteLine();

// matrixC[0, 0] = matrixA[0, 0] * matrixB[0, 0] + matrixA[0, 1] * matrixB[1, 0];
// matrixC[0, 1] = matrixA[0, 0] * matrixB[0, 1] + matrixA[0, 1] * matrixB[1, 1];
// matrixC[1, 0] = matrixA[1, 0] * matrixB[0, 0] + matrixA[1, 1] * matrixB[1, 0];
// matrixC[1, 1] = matrixA[1, 0] * matrixB[0, 1] + matrixA[1, 1] * matrixB[1, 1];

// for (int i = 0; i < matrixC.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixC.GetLength(1); j++)
//     {
//         Console.Write($"{matrixC[i, j],2} ");
//     }
//     Console.WriteLine();
// }


/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

// int[,,] array = new int[2, 2, 2];

// List<int> numbers = new List<int>();
// for (int i = 10; i < 100; i++)
// {
//     numbers.Add(i);
// }
// for (int i = 0; i < array.GetLength(0) && numbers.Count > 0; i++)
// {
//     for (int j = 0; j < array.GetLength(1) && numbers.Count > 0; j++)
//     {
//         for (int k = 0; k < array.GetLength(2) && numbers.Count > 0; k++)
//         {
//             int rand = new Random().Next(0, numbers.Count);
//             array[i, j, k] = numbers[rand];
//             numbers.RemoveAt(rand);
//         }
//     }
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//         }
//         Console.WriteLine();
//     }
// }

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

// int n = 4;
// int m = 4;
// int[,] array = new int[n, m];

// int iStart = 0, iEnd = 0, jStart = 0, jEnd = 0;
// int i = 0, j = 0, k = 1;

// while (k <= n * m)
// {
//     array[i, j] = k;
//     if (i == iStart && j < m - jEnd - 1)
//         ++j;
//     else if (j == m - jEnd - 1 && i < n - iEnd - 1)
//         ++i;
//     else if (i == n - iEnd - 1 && j > jStart)
//         --j;
//     else
//         --i;

//     if ((i == iStart + 1) && (j == jStart) && (jStart != m - jEnd - 1))
//     {
//         ++iStart;
//         ++iEnd;
//         ++jStart;
//         ++jEnd;
//     }
//     ++k;
// }

// Console.WriteLine();
// for (int row = 0; row < array.GetLength(0); row++)
// {
//     for (int col = 0; col < array.GetLength(1); col++)
//     {
//         Console.Write($"{array[row, col],3}");
//     }
//     Console.WriteLine();
// }