/*
__Написать программу копирования массива
*/
double[] a = new double[10];
double aCopy;

Console.Write("Оригинал ");
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(0, 100);
    Console.Write(a[i] + " ");
}
Console.WriteLine();
Console.Write("   Копия ");
for (int i = 0; i < a.Length; i++)
{
    aCopy = a[i];
    Console.Write(aCopy + " ");
}
Console.WriteLine();