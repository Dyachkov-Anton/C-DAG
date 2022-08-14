/*
Написать программу, которая в двумерном массиве заменяет 
строки на столбцы или сообщить, 
что это невозможно (в случае, если матрица не квадратная)
*/
void PrintArray(int[,] a)
{
    for (int m = 0; m < a.GetLength(0); m++)
    {
        for (int n = 0; n < a.GetLength(1); n++)
        {
            Console.Write($"{a[m, n]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] a)
{
    for (int m = 0; m < a.GetLength(0); m++)
    {
        for (int n = 0; n < a.GetLength(1); n++)
        {
            a[m, n] = new Random().Next(1, 10);
        }
    }
}
void Ordering(int[,] a)
{
    if (a.GetLength(0) == a.GetLength(1))
    {
        int[,] nums = new int[a.GetLength(0), a.GetLength(1)];
        for (int m = 0; m < a.GetLength(0); m++)
        {
            for (int n = 0; n < a.GetLength(1); n++)
            {
                nums[m, n] = a[m, n];
            }
        }
        for (int m = 0; m < a.GetLength(0); m++)
        {
            for (int n = 0; n < a.GetLength(1); n++)
            {
                a[m, n] = nums[n, m];
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
    }
}
int[,] matrix = new int[5, 6];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Ordering(matrix);
PrintArray(matrix);