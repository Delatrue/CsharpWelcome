// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Type number a: ");
int.TryParse(Console.ReadLine()!, out int numA);
Console.Write("Type number b: ");
int.TryParse(Console.ReadLine()!, out int numB);
if (numA > numB)
    Console.Write($"Max = {numA}, Min = {numB}\n");
else
    Console.Write($"Max = {numB}, Min = {numA}\n");



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Type number a: ");
// int.TryParse(Console.ReadLine()!, out int max);
// Console.Write("Type number b: ");
// int.TryParse(Console.ReadLine()!, out int numB);
// Console.Write("Type number c: ");
// int.TryParse(Console.ReadLine()!, out int numC);
// if(max < numB)
//     {
//         max = numB;
//         if(max < numC)
//         {
//             max = numC;
//         }
//         else
//         {
//             max = numB;
//         }
//     }    
// else if(max < numC)
//     {
//         max = numC;
//     }
// Console.Write($"Max = {max}\n");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Четное число или нет: ");
// int.TryParse(Console.ReadLine(), out int num);
// if(num % 2 == 0)
//     Console.Write($"{num} - да \n");
// else
//     Console.Write($"{num} - нет \n");



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
