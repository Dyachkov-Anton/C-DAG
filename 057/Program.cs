/*
Написать программу, упорядочивания по убыванию элементы 
каждой строки двумерной массива.
*/
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

void Ordering(int[,] a)
{
    for (int m = 0; m < a.GetLength(0); m++)
    {
        for (int n = 0; n < a.GetLength(1); n++)
        {
            for (int k = 0; k < a.GetLength(1) - n - 1; k++)
            {
                if (a[m, k] < a[m, k + 1])
                {
                    int t = a[m, k];
                    a[m, k] = a[m, k + 1];
                    a[m, k + 1] = t;
                }
            }
        }
    }
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Ordering(matrix);
PrintArray(matrix);
