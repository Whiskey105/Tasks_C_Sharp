/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

using System.Runtime.InteropServices;

void PrintArray(int[,] matrix)
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

void SortRowsDescending(int[,] matrix)
{
    
    for (int row = 0; row < matrix.GetLength(0); row++) //bubblesort for matrix
    {
        int temp = matrix [row,0];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[row,i] < matrix[row,j])
                {
                    temp = matrix[row,i];
                    matrix[row,i] = matrix[row,j];
                    matrix[row,j] = temp;
                }
            }
        }
    }
}
int[,] arr2d = CreateMatrixRndInt(4, 4, 0, 10);

PrintArray(arr2d);

SortRowsDescending(arr2d);

Console.WriteLine();
PrintArray(arr2d);
