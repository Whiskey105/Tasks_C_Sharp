/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

int firstNumber, secondNubmer;

Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondNubmer = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNubmer)
{
    Console.WriteLine($"первое число = {firstNumber}; второе число = {secondNubmer}; -> max = {firstNumber}; min = {secondNubmer};");
}
else
{
    Console.WriteLine($"первое число = {firstNumber}; второе число = {secondNubmer}; -> max = {secondNubmer}; min = {firstNumber};");
}