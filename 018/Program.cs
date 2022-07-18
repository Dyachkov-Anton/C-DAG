/*По двум заданным числам проверять является ли одно 
квадратом другого. Используйте подпрограмму.
*/

bool Check (int a, int b)
{
    return a*a==b || b*b==a;
}

int a = 5;
int b = 25;
if (Check(a, b))
    {
        System.Console.WriteLine("Yes");
    }
else
    {
        System.Console.WriteLine("No");
    } 
