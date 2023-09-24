/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int Promt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdDigit (int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool ValidateNumber (int num)
{
    if (num < 100)
    {
        Console.WriteLine($"{num} -> Третьей цифры нет");
        return false;
    }

    return true;
}

int number = Promt("Введите число: ");

if (ValidateNumber(number))
{
    Console.WriteLine($"{number} -> {GetThirdDigit(number)}");
}
