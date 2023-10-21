/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumOfNaturalElements(int numN, int numM)
{
    if (numN > numM)
    {
        return numN + SumOfNaturalElements(numN - 1, numM);
    }
    else if (numN < numM)
    {
        return numN + SumOfNaturalElements(numN + 1, numM);
    }
    else
    {
        return numN;
    }
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1 || M < 1)
{
    Console.WriteLine("Ошибка ввода!!!");
    return;
}

int sumOfNaturalElements = SumOfNaturalElements(N, M);

Console.WriteLine($"M = {M}; N = {N} -> {sumOfNaturalElements}");
