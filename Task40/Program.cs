/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник со сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

int Promt(string message)
{
    Console.Write(message);

    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

bool IsTriangleExsits(int first, int second, int third)
{
    return first + second > third && first + third > second && second + third > first;
}

int firstSide = Promt("Введите длину первой стороны: ");
int secondSide = Promt("Введите длину второй стороны: ");
int thirdSide = Promt("Введите длину третьей стороны: ");


bool result = IsTriangleExsits(firstSide, secondSide, thirdSide);

System.Console.WriteLine(result ? "Треугольник существует!" : "Треугольник не существует!");