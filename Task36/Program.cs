/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] CreataArrayRndInt(int size, int min, int max)
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
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
}

int GetSumOfNumbersOnNotEvevenPositions(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) continue;
        result += arr[i];
    }
    return result;
}

int[] array = CreataArrayRndInt(10, -10, 10);
int sumOfNumbersOnNotEvevenPositions = GetSumOfNumbersOnNotEvevenPositions(array);

Console.Write("[");
PrintArray(array);
Console.WriteLine($"] -> {sumOfNumbersOnNotEvevenPositions}");