using System.Linq;
/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
// Console.Write($"Введите числа через пробел: ");
// string numbers = Console.ReadLine();
// int positiveNum = 0;

// string[] numStrArray = numbers.Split(" ").ToArray();
// int[] numIntArray = numStrArray.Select(int.Parse).ToArray();
// for (int i = 0; i < numIntArray.Length; i++)
// {
//     if (numIntArray[i] > 0)
//         positiveNum++;
//     if (i < numIntArray.Length - 1)
//     {
//         Console.Write($"{numIntArray[i]}, ");
//     }
//     else
//     {
//         Console.WriteLine($"{numIntArray[i]} -> {positiveNum}");
//     }
// }



/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
\значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Найти точку пересечения двух прямых k и b");
Console.Write($"k1 = ");
double.TryParse(Console.ReadLine(), out double k1);
Console.Write($"k2 = ");
double.TryParse(Console.ReadLine(), out double k2);
Console.Write($"b1 = ");
double.TryParse(Console.ReadLine(), out double b1);
Console.Write($"b2 = ");
double.TryParse(Console.ReadLine(), out double b2);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"({x}; {y})");