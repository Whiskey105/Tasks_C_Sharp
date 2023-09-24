/* Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N. */

void PrintTableSquare (int num)
{
    Console.WriteLine($"Таблица кваратов чиcла {num}");
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i,3} -> {i*i,5}");
    }
}

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintTableSquare(number);

