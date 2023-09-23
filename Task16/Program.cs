/* Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

bool IsSquareOfTwoNumbers(int num1, int num2)
{
    return Math.Sqrt(num1) == num2 || Math.Sqrt(num2) == num1;
}

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNubmer = Convert.ToInt32(Console.ReadLine());

bool result = IsSquareOfTwoNumbers(firstNumber, secondNubmer);

Console.WriteLine(result ? $"{firstNumber}, {secondNubmer} -> Да" : $"{firstNumber}, {secondNubmer} -> Нет");