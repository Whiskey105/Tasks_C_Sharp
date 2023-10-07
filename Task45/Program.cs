/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] CopyArray(int[] sourceArray)
{
    int[] arr = new int[sourceArray.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = sourceArray[i];
    }

    return arr;
}


int[] array = CreateArrayRndInt(15, 1, 9);
int[] arrCopy = CopyArray(array);

PrintArray(array);
Console.Write(" -> ");
PrintArray(arrCopy);



