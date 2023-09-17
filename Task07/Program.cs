/* 7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8 */

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    number *= -1;
}

if (99 < number && number < 1000)
{
    int lastNumbmer = number % 10;
    Console.WriteLine($"{number} -> {lastNumbmer}");
}
else if (-99 > number && number > -1000)
{
    Console.WriteLine("Неверное значение!");
}

