/*С клавиатуры вводится целое число. Вывести квадрат числа
int a = 2;
int c = 4;
int g = a + c;
Console.WriteLine("{0}+{1}={2}", a, c, g);
double
*/

int a;
int b;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
Console.WriteLine($"{a}^2={b}");
