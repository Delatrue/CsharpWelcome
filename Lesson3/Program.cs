/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

// Console.Write("Введите 5-ти значное число: ");
// if (num[index] == num[lastIndex] && num[index++] == num[lastIndex--])
//     Console.WriteLine(num + " -> да");
// else
//     Console.WriteLine(num + " -> нет");


/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

// Console.Write("Координаты точки А(x): ");
// int.TryParse(Console.ReadLine(), out int x1);
// Console.Write("Координаты точки А(y): ");
// int.TryParse(Console.ReadLine(), out int y1);
// Console.Write("Координаты точки А(z): ");
// int.TryParse(Console.ReadLine(), out int z1);

// Console.Write("Координаты точки B(x): ");
// int.TryParse(Console.ReadLine(), out int x2);
// Console.Write("Координаты точки B(y): ");
// int.TryParse(Console.ReadLine(), out int y2);
// Console.Write("Координаты точки B(z): ");
// int.TryParse(Console.ReadLine(), out int z2);

// double distanceAB = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2);

// Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2}{y2}{z2}), -> {distanceAB}");



/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

// Console.Write("Введите число: ");
// int.TryParse(Console.ReadLine(), out int numN);

// for (int i = 1; i <= numN; i++)
// {
//     Console.Write($"{i * i * i}");
//     if (i < numN)
//         Console.Write(", ");
//     else
//         Console.WriteLine("");
// }