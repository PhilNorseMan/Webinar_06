// Задача на разворот массива

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

int[] ReverseArray(int[] input)
{
    int[] array = new int[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        array[i] = input[input.Length - i - 1];
    }

    return array;
}

var array = CreateArray(10, 0, 10);
Print(array);
var newArray = ReverseArray(array);
Print(newArray);

