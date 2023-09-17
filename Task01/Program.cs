/* Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */

int firstNumber, secondNubmer;

Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondNubmer = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNubmer * secondNubmer)
{
    Console.WriteLine($"первое число = {firstNumber}, второе число = {secondNubmer} -> Да");
}
else
{
    Console.WriteLine($"первое число = {firstNumber}, второе число = {secondNubmer} -> Нет");
}

