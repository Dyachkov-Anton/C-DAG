﻿/*С клавиатуры вводятся два числа a и b. 
Найти максимальное из них
*/
double a,b;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if (a>b)
{
    System.Console.WriteLine(a);
}
else 
{
    System.Console.WriteLine(b);
}