/*
Показать натуральные числа от M до N, N и M заданы
*/
void PrintNumber(int M, int N)
{
    if (N < M) return;
    PrintNumber(M, N - 1);
    Console.Write(N + " ");
}
PrintNumber(10,20);