/* С клавиатуры вводится целое число из  диапазона  [10, 99]. 
Показать наибольшую цифру числа
*/
int a=77;
int b=a/10;
int c=a%10;
int d = Math.Max(b, c);
System.Console.WriteLine(d);