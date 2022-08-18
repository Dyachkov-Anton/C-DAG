/*
Показать натуральные числа от 1 до N, N задано
*/

void PrintNumber(int N)
{
    if (N < 1) return;
    PrintNumber(N - 1);
    Console.Write(N + " ");
}
PrintNumber(100);

