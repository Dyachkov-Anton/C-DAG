/*
С клавиатуры вводится число N. Затем вводятся N чисел. 
Определить сколько чисел больше 0 введено с клавиатуры
*/
/*using System;
Console.ReadLine();
string s=Console.ReadLine(); Split(' ').Select(x => int.Parse(x)).ToArray();
string[] ss=s.Split(' ');
int k=0;
for(int i=ss.Length-1;i>=0;i++)
    if (s[i]>0)
    k++;
System.Console.WriteLine(k);
*/ 

Console.Write("Введите числа через пробел: ");

int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();;

int Numbers(int[] a)
{
    int k = 0;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0) k++;
    }
    return k;
}
Console.WriteLine(Numbers(a));
