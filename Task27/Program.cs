/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Promt(string message)
{
    Console.Write(message);
    
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

int SumOfDigits(int num)
{
    int result = 0;

    if (num < 0)
    {
        num *= -1;
    }

    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }

    return result;
}


int number = Promt("Введите число: ");
int sumOfDigits = SumOfDigits(number);

Console.WriteLine($"{number} -> {sumOfDigits}");