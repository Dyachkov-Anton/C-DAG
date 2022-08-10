/*
С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
Принять первые числа равными 0 и 1
*/
int N =int.Parse(Console.ReadLine());
int f1 = 0;
int f2 = 1;
int result;
for (int i = 0; i < N; i++)
{
    result = f1 + f2;
    Console.Write(result + " ");
    f1 = f2;
    f2 = result;
}
