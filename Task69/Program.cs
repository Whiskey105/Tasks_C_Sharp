/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int PowerOfNumber(int num, int pow)
{
    if (pow == 0) return 1;
    return num * PowerOfNumber(num, pow - 1);
}

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число P: ");
int P = Convert.ToInt32(Console.ReadLine());


int powerOfNumber = PowerOfNumber(N, P);

Console.WriteLine($"N = {N}; P = {P} -> {powerOfNumber}");
