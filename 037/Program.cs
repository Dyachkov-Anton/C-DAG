/*
Задать массив, заполнить случайными положительными 
трёхзначными числами. Показать количество нечетных\четных чисел
*/
int N=5;
int [] a=new int[N];
Random random=new Random();
for (int i=0; i<a.Length; i++)
{
    a[i]=random.Next(100,999);
}

int evenNumber=0;
int oddNumber=0;
for (int i=0; i<a.Length; i++)
    {
        if (a[i]%2==0)
        {
            ++evenNumber;
        }
        else
        ++oddNumber;
    }   
for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();
System.Console.WriteLine($"Even Number:{evenNumber}");
System.Console.WriteLine($"Odd Number:{oddNumber}");