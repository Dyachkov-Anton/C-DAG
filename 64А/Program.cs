﻿/*
Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/
void PrintNumber(int M, int N)
{
    if (N < M) return;
    PrintNumber(M, N - 1);
    Console.Write(N + " ");
}
PrintNumber(1,5);
Console.WriteLine();
PrintNumber(4,8);
Console.WriteLine();