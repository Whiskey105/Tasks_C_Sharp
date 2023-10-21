/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int AckermannFunction(int numN, int numM)
{
    if (numN == 0)
    {
        return numM + 1;
    } 
    else
    {
        if ((numN != 0) && (numM == 0))
        {
            return AckermannFunction(numN - 1, 1);
        } 
        else 
        {
            return AckermannFunction(numN - 1, AckermannFunction(numN, numM - 1));
        }
    }
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0 || M < 0)
{
    Console.WriteLine("Ошибка ввода!!!");
    return;
}

int ackermannResult = AckermannFunction(M, N);

Console.WriteLine($"m = {M}, n = {N} -> A({M},{N}) = {ackermannResult}");
