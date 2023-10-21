/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.WriteLine($"{arr[i]}");
    }
}

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

int SumOfRow(int[,] matrix, int row)
{
    int sum = matrix[row, 0];
    for (int column = 1; column < matrix.GetLength(1); column++)
    {
        sum += matrix[row, column];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int minSumRow = SumOfRow(matrix, 0);
    int rowIndex = 0;

    for (int row = 1; row < matrix.GetLength(0); row++)
    {
        if (minSumRow > SumOfRow(matrix, row))
        {
            minSumRow = SumOfRow(matrix, row);
            rowIndex = row;
        }
    }

    int[] resultArray = new int[2] { rowIndex, minSumRow };
    return resultArray;
}

int[,] arr2d = CreateMatrixRndInt(4, 4, 0, 10);

PrintMatrix(arr2d);

int[] minSumRow = MinimumSumRow(arr2d);

Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

int rowToSum = 1;
int sum = SumOfRow(arr2d, rowToSum);
Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");
