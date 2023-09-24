void PrintTableSquare (int num)
{
    Console.WriteLine($"Таблица кубов чиcла {num}");
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i,3} -> {Math.Pow(i, 3),5}");
    }
}

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintTableSquare(number);
