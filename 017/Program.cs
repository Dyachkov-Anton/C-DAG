/* Дано число обозначающее день недели. 
Выяснить является номер дня недели выходным
*/
int dayOfWeek;
dayOfWeek=int.Parse(Console.ReadLine());

switch (dayOfWeek)
{
    case 1:
        System.Console.WriteLine("Не выходной!!!");
        break;
    case 2:
        System.Console.WriteLine("Не выходной!!!");
        break;
    case 3:
        System.Console.WriteLine("Не выходной!!!");
        break;
    case 4:
        System.Console.WriteLine("Не выходной!!!");
        break;
    case 5:
        System.Console.WriteLine("Не выходной!!!");
        break;
    case 6:
        System.Console.WriteLine("Выходной - суббота!!!");
        break;
    case 7:
        System.Console.WriteLine("Выходной - воскресенье!!!");
        break;
    default:
        System.Console.WriteLine("Oшибка!!!");
        break;
}