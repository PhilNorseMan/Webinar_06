/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

int[] CreateArray(int lengthArray, int startInterval, int endInterval)
{
    int[] array = new int[lengthArray];

    Random random = new Random();

    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = random.Next(startInterval, endInterval + 1);
    }

    return array;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);

        if (i != arr.Length - 1)
            Console.Write(" | ");
    }

    Console.WriteLine();
}

int[] CopyArray(int[] input)
{
    int[] array = new int[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        array[i] = input[i];
    }

    return array;
}

var array = CreateArray(10, 0, 10);
Print(array);
var newArray = CopyArray(array);
Print(newArray);