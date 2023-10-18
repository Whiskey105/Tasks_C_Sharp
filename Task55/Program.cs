/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

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

void ChangeRows(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;
        }
    }
}


int[,] arr2d = CreateMatrixRndInt(4, 4, 0, 10);

PrintMatrix(arr2d);

if (arr2d.GetLength(1) != arr2d.GetLength(0))
{
    Console.WriteLine("Невозможно поменять строки столбцы");
    return;
}

Console.WriteLine();
PrintMatrix(arr2d);