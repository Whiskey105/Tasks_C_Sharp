/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 -> 10 */

int Promt(string message)
{
    Console.Write(message);

    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

int ChangeNumbersCountingSystem(int num, int cap)
{
    int res = 0;
    int mult = 1;
    while (num > 0)
    {
        res += num % cap * mult;
        num = num / cap;
        mult *= 10;
    }

    return res;
}

/* string DecimalToBinaryStr(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;// num /= 2 //
    }
    return result;
} */

int number = Promt("Число: ");
int typeOfCountingSystem = Promt("разрядность системы (от 2 до 10): ");

if (typeOfCountingSystem > 10 || typeOfCountingSystem < 2)
{
    Console.WriteLine("Конвертация невозможна!"); 
    return;
}

int result = ChangeNumbersCountingSystem(number, typeOfCountingSystem);

Console.WriteLine($"Результат конвертации = {result}");