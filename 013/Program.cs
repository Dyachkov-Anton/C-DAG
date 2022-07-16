/* Удалить вторую цифру целого числа введенного с клавиатуры.
*/
int a=Convert.ToInt32(Console.ReadLine());
int b = a%10;
int c = a/100;
a = c*10+b;
System.Console.WriteLine(a);