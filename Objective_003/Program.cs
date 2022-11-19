/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] Fibonacci(int size)
{
    int[] line = new int[size];
    line[0] = 0;
    line[1] = 1;
    for (int i = 2; i < line.Length; i++)
    {
        line[i] = line[i - 1] + line[i - 2];
    }

    return line;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);

        if (i != arr.Length - 1)
            Console.Write(", ");
    }

    Console.WriteLine();
}

Console.WriteLine("Please, enter SIZE for Fibonacci line(0, 1, ...):");
int userSize = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Fibonacci line for {userSize} is:");

Print(Fibonacci(userSize));