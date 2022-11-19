/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

string DecimalToBinar(int n)
{
    if (n == 1 ) return "1";
    if (n == 0 ) return "0";
    int remain = n%2;
    int div = n/2;
    return DecimalToBinar(div) + remain;
}


Console.WriteLine("Please, enter decimal number to convert to binar number:");
int number = int.Parse(Console.ReadLine()!);

string nBinar = DecimalToBinar(number);

Console.WriteLine($"Result of convertation is: {nBinar}.");