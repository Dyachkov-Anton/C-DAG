/*
Показать натуральные числа от N до 1, N задано
*/

void PrintNumber(int N)
{
    if (N < 1) return;
    Console.Write(N + " ");
    PrintNumber(N - 1);
}
PrintNumber(5);
