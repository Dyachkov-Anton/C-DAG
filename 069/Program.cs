/*
Найти сумму элементов от M до N, N и M заданы - 1
*/
int Sum(int M, int N)
{
    if (N == M) return N;
    return M + Sum(M + 1, N);
}
Console.WriteLine(Sum(1, 10));
