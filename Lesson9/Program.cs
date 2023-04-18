/* Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


// RecurN(5);
// Console.WriteLine();
// RecurN(8);

// void RecurN(int num)
// {
//     Console.Write($"{num}, ");
//     num--;
//     if (num > 0)
//         RecurN(num);
// }




/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */



// int SumElements(int numM, int numN)
// {
//     return (numM + numN) * (numN - numM + 1) / 2;
// }

// Console.WriteLine(SumElements(4, 8));




/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */



int AkkermanFunc(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if (numM > 0 && numN == 0)
    {
        return AkkermanFunc(numM - 1, 1);
    }
    return AkkermanFunc(numM - 1, AkkermanFunc(numM, numN - 1));
}

Console.WriteLine(AkkermanFunc(3, 2));