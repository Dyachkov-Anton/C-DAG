﻿/*
Найти точку пересечения двух прямых заданных уравнением 
y = k1 * x + b1, 
y = k2 * x + b2, 
b1 k1 и b2 и k2 заданы
*/
string X(int k1, int k2, int b1, int b2)
{
    string result = string.Empty;
    int x = 0;
    int y = 0;
    y = (k1 * x + b1);
    y = (k2 * x + b2);
    result = $"({x}, {y})";
    return result;
}
Console.WriteLine(X(-2, 3, 3, -2));