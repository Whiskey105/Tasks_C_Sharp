/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.WriteLine($"{arr[i]}");
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine(" |");
    }
}

int [] ConverMatrixToArray(int[,] matrix)
{
    int [] result = new int [matrix.Length]; 
    int count = 0;
    foreach (int item in matrix)
    {
        result[count++] = item;
    }
    return result;
}

void PintFreqencyDictionary (int [] arr)
{
    int count = 1;
    Array.Sort(arr);
    int currentNum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (currentNum == arr[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{currentNum} -> {count}");
            currentNum = arr[i];
            count = 1;
        }
    }
}

int[,] arr2d = CreateMatrixRndInt(4, 4, 0, 10);

PrintMatrix(arr2d);

Console.WriteLine();

int [] array = ConverMatrixToArray(arr2d);

PrintArray(array);

Console.WriteLine();

PintFreqencyDictionary(array);


