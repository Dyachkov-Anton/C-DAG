/*
Выяснить является ли число чётным.
*/
double a;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
if (a%2==0)
{
    System.Console.WriteLine($"{a} - even number!!!");
}
else 
{
    System.Console.WriteLine($"{a} - odd number!!!");
}