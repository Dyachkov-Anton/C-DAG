﻿/*
Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
56
*/

double x1=double.Parse(Console.ReadLine());
double y1=double.Parse(Console.ReadLine());
double x2=double.Parse(Console.ReadLine());
double y2=double.Parse(Console.ReadLine());
double x3=double.Parse(Console.ReadLine());
double y3=double.Parse(Console.ReadLine());
double x4=double.Parse(Console.ReadLine());
double y4=double.Parse(Console.ReadLine());
double k=double.Parse(Console.ReadLine());
{
    x1 = x1 * k;
    y1 = y1 * k;
    x2 = x2 * k;
    y2 = y2 * k;
    x3 = x3 * k;
    y3 = y3 * k;
    x4 = x4 * k;
    y4 = y4 * k;
}
Console.WriteLine($"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})");

