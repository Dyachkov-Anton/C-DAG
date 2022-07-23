/* 
Написать программу замены элементов массива на противоположные
*/
/*int N=3;
int [] a=new int[N];
Random random=new Random();
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-5, 5);
for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();
*/
int[] a = new int[3];
            Random r = new Random();

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i<a.Length;i++)
            {
                a[i] = r.Next(-5, 5);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Измененный массив: ");
            for (int i =0; i < a.Length; i++)
            {
                a[i] = a[i] * (-1);
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();