/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

void TriangleTestBySidesValues(float value1, float value2, float value3)
{
    if(value1 < value2 + value3 && value2 < value1 + value3 && value3 < value1 + value2)
    {
        Console.WriteLine("Yes, there can be triangle with such sides.");
    }
    else
    {
        Console.WriteLine("No, there can't be triangle with such sides.");
    }
   
}

Console.WriteLine("Please, enter first number:");
float number1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Please, enter second number:");
float number2 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Please, enter third number:");
float number3 = float.Parse(Console.ReadLine()!);

TriangleTestBySidesValues(number1, number2, number3);