/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое
каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

static double[] FindAverageInColumns(int[,] matrix)
{
    double[] res = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            res[i] += matrix[j,i];
        }
        res[i] /= matrix.GetLength(0);
    }
    return res;
}

static void PrintListAvr(double[] list)
{
    Console.WriteLine("The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]:F2}\t");
    }
}


int[,] arr2d = CreateIncreasingMatrix(3, 4, 2);
double[] arrDouble = FindAverageInColumns(arr2d);

PrintArray(arr2d);
PrintListAvr(arrDouble);



