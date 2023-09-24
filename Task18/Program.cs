/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */


string QuarterRange(int num)
{
    if (num == 1) return "Диапазон четверти x > 0 : y > 0";
    if (num == 2) return "Диапазон четверти x < 0 : y > 0";
    if (num == 3) return "Диапазон четверти x < 0 : y < 0";
    if (num == 4) return "Диапазон четверти x > 0 : y < 0";
    
    return null;
}

Console.WriteLine("Введите номер четвети");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = quarter != null 
                            ? result 
                            : "Введен некорректный номер четверти";

Console.WriteLine(result);