/* С клавиатуры вводятся два вещественных числа. 
Проверять является ли одно из них квадратом второго (блок-схема)
*/
double a,b;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if (a*a==b)
{
    System.Console.WriteLine("a is square b");
}
else 
{
    System.Console.WriteLine("a is not square b");
}

if (b*b==a)
{
    System.Console.WriteLine("b is square a");
}
else 
{
    System.Console.WriteLine("b is not square a");
}