/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    int incr = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = incr;
            incr += k;
        }
    }

    return matrix;
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    bool res = 
    if ((rowPosition < matrix.GetLength(0) && rowPosition > 0) && (columnPosition < matrix.GetLength(1) && columnPosition > 0))
    {
        int[] results = new int[2] {matrix[rowPosition, columnPosition], 0};
        return results;
    }
    else
    {
        int[] results = new int[1] {0};
        return results;
    }
    
}

void PrintCheckIfError(int[] results, int X, int X)
{
    if (results.Length != 2)
    {
        Console.WriteLine("There is no such index");
    }
    else
    {
        Console.WriteLine($"The number in [{X}, {X}] is {results[0]}");
    }
}

int[,] arr2d = CreateIncreasingMatrix(4, 4, 5);

PrintArray(arr2d);

PrintCheckIfError(FindNumberByPosition(arr2d, 4, 2), 4, 2);