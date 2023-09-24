/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int GetSecondDigit(int num)
{
    return num / 10 % 10;
}

int Promt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Promt("Введите трехзнаечное число: ");

if (number < 100 || number > 999)
{
    Console.WriteLine("Out of range exception");
    return;
}

Console.WriteLine($"{number} -> {GetSecondDigit(number)}");
