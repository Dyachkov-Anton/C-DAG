﻿/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int Sum(int M, int N)
{
    if (N == M) return N;
    return M + Sum(M + 1, N);
}
Console.WriteLine(Sum(1, 15));
Console.WriteLine(Sum(4, 8));
