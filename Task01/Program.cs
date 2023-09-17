int firstNumber, secondNubmer;

Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondNubmer = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNubmer*secondNubmer)
{
    Console.WriteLine($"первое число = {firstNumber}, второе число = {secondNubmer} -> Да");
}
else
{
    Console.WriteLine($"первое число = {firstNumber}, второе число = {secondNubmer} -> Нет");
}

