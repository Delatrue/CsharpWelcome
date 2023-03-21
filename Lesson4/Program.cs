/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

// Console.Write("Число А: ");
// int.TryParse(Console.ReadLine(), out int numA);
// Console.Write("Число B: ");
// int.TryParse(Console.ReadLine(), out int numB);

// Console.WriteLine(DeegreAtoB(numA, numB));

// int DeegreAtoB(int _numA, int _numB)
// {
//     int result = 1;
//     for (int i = 1; i <= _numB; i++)
//     {
//         result *= numA;
//     }
//     return result;
// }


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Число: ");
int.TryParse(Console.ReadLine(), out int numA);

Console.WriteLine($"{numA} -> {numA % 10 + numA / 10 % 10 + numA / 100 % 10 + numA / 1000 % 10}");
