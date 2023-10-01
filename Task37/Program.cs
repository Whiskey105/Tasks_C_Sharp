/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


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

int Promt(string message)
{
    Console.Write(message);

    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
}

int[] GetArrayOfPairMultiplication(int[] arr)
{
    int size = arr.Length / 2;

    if (arr.Length % 2 != 0) size += 1;

    int[] arrResult = new int[size];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrResult[i] = arr[i] * arr[arr.Length - i - 1];
    }

    if (arr.Length % 2 != 0) arrResult[size - 1] = arr[size - 1];

    return arrResult;
}

int[] array = CreateArrayRndInt(15, 1, 9);

Console.Write("[");
PrintArray(array);
Console.WriteLine($"]");

int[] arrayOfPair = GetArrayOfPairMultiplication(array);

Console.Write("[");
PrintArray(arrayOfPair);
Console.WriteLine($"]");
