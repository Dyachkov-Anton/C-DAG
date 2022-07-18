/* 
Написать программу вычисления произведения чисел от 1 до N
*/
int N = int.Parse(Console.ReadLine());
int multiplication=1;
    for (int i = 1; i <= N; i++)
    multiplication*= i;
Console.WriteLine(multiplication);
Console.ReadKey();