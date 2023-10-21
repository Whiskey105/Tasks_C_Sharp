/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int SumOfDigits(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumOfDigits(num / 10);
}

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sumOfDigits = SumOfDigits(N);

Console.WriteLine($"{N} -> {sumOfDigits}");
