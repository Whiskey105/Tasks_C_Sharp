/* Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

int SumOfAllNumbers (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}


System.Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());



System.Console.WriteLine($"{number} -> {SumOfAllNumbers(number)}");

