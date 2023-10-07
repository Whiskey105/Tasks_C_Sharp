/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int[] FibonacciArray(int size)
{
    int[] arr = new int[size];
    //arr[0] = 0;
    arr[1] = 1;

    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }

    return arr;
}

int Promt(string message)
{
    Console.Write(message);

    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
}

int fibonacciRowSize = Promt("Введите N (больше 1) чисел ряда Фибоначи для вывода: ");

if (fibonacciRowSize < 2)
{
    Console.Write("Неверный ввод! Введите чило больше 1!");
    return;
}

int[] fibonacciRowArray = FibonacciArray(fibonacciRowSize);

Console.Write($"Если N = {fibonacciRowSize} -> ");
PrintArray(fibonacciRowArray);
