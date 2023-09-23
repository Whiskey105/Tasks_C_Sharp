/* Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */


bool MultipltToIwoNumbers(int num1, int num2, int num3)
{
    return num1 %  num2 == 0 && num1 %  num3 == 0;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = 7;
int secondNubmer = 23;

bool result = MultipltToIwoNumbers(number, firstNumber, secondNubmer);

Console.WriteLine(result ? $"{number} -> кратно" : $"{number} -> не кратно");