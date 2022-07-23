/*
Показать кубы чисел, заканчивающихся на четную цифру
*/
Console.WriteLine("Введите число a равное 2");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
    while (a <= N)
        {
            Console.WriteLine("{0} {1}", a, a * a* a);
                a=a+2;
        }
        Console.ReadKey();