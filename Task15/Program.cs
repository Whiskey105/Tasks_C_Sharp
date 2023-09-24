/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateWeekdayNuber(int num)
{
    if (num > 0 && num < 8)
    {
        return true;
    }
    Console.WriteLine($"{num} -> Не соответвует номеру дня недели");
    return false;
}

bool IsWeekend(int num)
{
    if (num > 5)
    {
        return true;
    }
    return false;
}

int number = Promt("Введите номер дня недели: ");

if (ValidateWeekdayNuber(number))
{
    if (IsWeekend(number))
    {
        Console.WriteLine($"{number} -> Да");
    }
    else
    {
        Console.WriteLine($"{number} -> Нет");
    }

}

