/*
Определить количество цифр в числе. Сделать подпрограмму.
*/

int Countdigits (int N)
{
    if (N==0) return 1;
    int k = 0;
    while (N!=0)
    {
        k++;
        N/=10; 
    }
    return k;
}
System.Console.WriteLine(Countdigits(0));