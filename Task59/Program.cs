/* Задача 59: Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива. */

using System.Buffers;

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

int[] GetIndexesOfMinElem(int[,] matrix)
{
    int minElemRow = 0;
    int minElemColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minElemRow, minElemColumn])
            {
                minElemRow = i;
                minElemColumn = j;
            }
        }
    }
    return new int[] { minElemRow, minElemColumn };
}

int[,] DeleteRowColumnMinElem(int[,] matrix, int delRow, int delColumn)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0, m = 0; i < result.GetLength(0); i++, m++)
    {
        if (i == delRow) m++;
        for (int j = 0, n = 0; j < result.GetLength(1); j++, n++)
        {
            if (j == delColumn) n++;
            result[i,j] = matrix[m,n];
        }
    }

    return result;
}


int[,] matrixRND = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrixRND);

int [] arr = GetIndexesOfMinElem(matrixRND);

int[,] newMatrix = DeleteRowColumnMinElem(matrixRND, arr[0], arr[1]);

Console.WriteLine();

PrintMatrix(newMatrix);

