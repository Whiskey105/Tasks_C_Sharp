/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */


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
    //Console.Write($"[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }

    // Console.Write($"]");
}

bool FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }

    return false;
}

int[] array = CreateArrayRndInt(12, -9, 9);
int number = 4;

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

bool isNumberInArray = FindNumber(array, number);

if (isNumberInArray)
{
    Console.Write($"{number}");
    Console.Write("[");
    PrintArray(array);
    Console.WriteLine("] -> да");
}
else
{
    Console.Write($"{number}");
    Console.Write("[");
    PrintArray(array);
    Console.WriteLine("] -> нет");
}

