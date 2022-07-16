/*
Вывести на экран числа от -N до N
*/

int n;
int N;
string? s=Console.ReadLine();
n=Convert.ToInt32(s);
s=Console.ReadLine();
N=Convert.ToInt32(s);
while (n<=N)
{
    System.Console.Write($"{n} ");
    n=n+1; 
}