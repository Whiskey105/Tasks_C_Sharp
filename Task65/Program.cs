/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

void NaturalNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        NaturalNumbers(firstNumber - 1, secondNumber);
        Console.Write($"{firstNumber} ");
    }
    else if (firstNumber < secondNumber)
    {
        Console.Write($"{firstNumber} ");
        NaturalNumbers(firstNumber + 1, secondNumber);
    }
    else
    {
        Console.Write($"{firstNumber} ");
    }
}

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(N, M);
