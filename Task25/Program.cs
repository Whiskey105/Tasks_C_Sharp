/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int NumPow(int num, int power)
{
    int result = 1;

    for (int i = 1; i <= power; i++)
    {
        result *= num;
    }

    return result;
}


int number = Promt("Введите число для возведения в степень: ");
int pow = Promt("Введите степень числа: ");

int poweredNum = NumPow(number, pow);

System.Console.WriteLine($"{number}, {pow} -> {poweredNum}");
