/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int firstNumber, secondNubmer, thirdNumber;

Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondNubmer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumber;

if(maxNumber < firstNumber) maxNumber = firstNumber;
if(maxNumber < secondNubmer) maxNumber = secondNubmer;
if(maxNumber < thirdNumber) maxNumber = thirdNumber;

Console.WriteLine($"{firstNumber}; {secondNubmer}; {thirdNumber}; -> max = {maxNumber}");
