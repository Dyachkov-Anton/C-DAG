/*
C клавиатуры вводится строка разделенная точкой. 
Подсчитать количество символов до точки
*/
Console.WriteLine("Do string");
string str = Console.ReadLine();
int countBefore = str.LastIndexOf('.');
Console.WriteLine(countBefore);