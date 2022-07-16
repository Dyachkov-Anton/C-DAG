/* Дано число больше 9. 
Вывести на экран  вторую цифру числа с конца
*/
int number=Convert.ToInt32(Console.ReadLine());
if (number>9)
    {
        Console.WriteLine(number.ToString()[1]);
    }
else
{
        Console.WriteLine("Не правильное число !!!");
    }
