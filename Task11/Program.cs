/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98 */

int RemoveMidDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    return firstDigit * 10 + lastDigit;
}

int randNumber = new Random().Next(100, 1000); 
int twoDigitNumber = RemoveMidDigit(randNumber);

Console.WriteLine($"{randNumber} -> {twoDigitNumber}");

