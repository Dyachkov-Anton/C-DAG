/* Вывести на экран таблицу квадратов чисел от 1 до N
*/
Console.WriteLine("Введите число a = 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
    while (a <= N)
        {
            Console.WriteLine("{0} {1}", a, a * a);
                a++;
        }
        Console.ReadKey();