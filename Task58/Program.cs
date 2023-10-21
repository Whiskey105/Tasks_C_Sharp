/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{ // Введите свое решение ниже
    if (matrixA.GetLength(1) != matrixB.GetLength(1))
    {
        Console.WriteLine("It is impossible to multiply.");
    }
    else
    {
        int[,] multipliedMatrix = MatrixMultiplication(matrixA, matrixB);
        Console.WriteLine("Multiplication result: ");
        PrintMatrix(multipliedMatrix);
    }

}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{  // Введите свое решение ниже
    int[,] multipliedMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < multipliedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multipliedMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLongLength(1); k++)
            {
                multipliedMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return multipliedMatrix;
}

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

int[,] matrixA = CreateMatrixRndInt(4, 4, 0, 10);

Console.WriteLine("Matrix A");
PrintMatrix(matrixA);

int[,] matrixB = CreateMatrixRndInt(4, 4, 0, 10);

Console.WriteLine("Matrix B");
PrintMatrix(matrixB);

MultiplyIfPossible(matrixA, matrixB);


