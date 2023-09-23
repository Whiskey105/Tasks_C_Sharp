/* Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если первое число не кратно
второму, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

/* bool IsMultiplicated(int num1, int num2)
{
    int result = num1 % num2;
    return result == 0;
} */

int GetDivisionRemainder(int num1, int num2)
{
    int result = num1 % num2;
    return result;
}

int firstNumber, secondNubmer;

Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondNubmer = Convert.ToInt32(Console.ReadLine());


/*if (IsMultiplicated(firstNumber, secondNubmer))
{
    Console.WriteLine($"{firstNumber}, {secondNubmer} -> кратно");
}
else
{
    int remainder = GetDivisionRemainder(firstNumber, secondNubmer);
    Console.WriteLine($"{firstNumber}, {secondNubmer} -> не кратно, остаток {remainder}");
}  */

int remainder = GetDivisionRemainder(firstNumber, secondNubmer);

if (remainder == 0)
{
    Console.WriteLine($"{firstNumber}, {secondNubmer} -> кратно");
}
else
{
    Console.WriteLine($"{firstNumber}, {secondNubmer} -> не кратно, остаток {remainder}");
} 