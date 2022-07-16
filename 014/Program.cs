/*С клавиатуры вводятся два числа a и b. 
Выяснить, кратно ли число a числу b, если нет, 
вывести остаток от деления a на b.

*/

int a;
int b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
if (a%b==0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine(a%b);
}