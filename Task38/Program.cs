/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] CreataArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + max;
    }

    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}; ");
        else Console.Write($"{arr[i]:F2}");
    }
}

double GetMaxElem(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double GetMinElem(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}


double[] array = CreataArrayRndDouble(10, -10, 10);
double maxElem = GetMaxElem(array);
double minElem = GetMinElem(array);
double diff = maxElem - minElem;


Console.Write("[");
PrintArray(array);
Console.WriteLine($"] => {maxElem:F2} - {minElem:F2} = {diff:F2}");
