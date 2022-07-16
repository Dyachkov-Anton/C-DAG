/* 
С клавиатуры вводятся три числа. 
Найти максимальное из трех чисел
*/
double a,b,c;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
s=Console.ReadLine();
c=Convert.ToDouble(s);
if (a>b&a>c)
{
    System.Console.WriteLine(a);
}  
if (b>c&b>a)
{
    System.Console.WriteLine(b);
}
if (c>a&c>b)
{
    System.Console.WriteLine(c);
}