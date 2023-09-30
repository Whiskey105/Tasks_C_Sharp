

int Factorial(int num)
{
    int res = 1;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
            res *= i; 
        }
    }

    return res;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int factorial = Factorial(number);
Console.WriteLine($"Факториал числа {number} = {factorial}");