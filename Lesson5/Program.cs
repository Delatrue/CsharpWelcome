/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

// int[] array = new int[4];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 999);

//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }

// }
// ArrayPrint();
// Console.WriteLine(count);

// void ArrayPrint()
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1)
//             Console.Write($"{array[i]}");
//         else
//             Console.Write($"{array[i]}, ");
//     }
//     Console.Write("] -> ");
// }


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


// int[] array = new int[4];
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 99);
// }
// for (int i = 1; i < array.Length; i += 2)
// {
//     sum += array[i];
// }

// ArrayPrint();
// Console.WriteLine(sum);

// void ArrayPrint()
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1)
//             Console.Write($"{array[i]}");
//         else
//             Console.Write($"{array[i]}, ");
//     }
//     Console.Write("] -> ");
// }



/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76 */

double[] array = { 3.1, 7.5, 22.12, 78.5 };
double max = 0, min = 0;

for (int i = 0; i < array.Length; i++)
{
    //array[i] = new Random().NextDouble();
    if (array[i] > max)
        max = array[i];
    else if (array[i] < min)
        min = array[i];
}
ArrayPrint();
Console.WriteLine($"max = {max} min = {min}");
Console.WriteLine(max - min);

void ArrayPrint()
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write($"{array[i]}");
        else
            Console.Write($"{array[i]}, ");
    }
    Console.Write("] -> ");
}
