// See https://aka.ms/new-console-template for more information

using System;

bool IsPalindrome(int num)
{
    int buf = num;
    int reversedNum = 0;

    while (buf > 0)
    {   
        reversedNum *= 10;
        reversedNum += buf % 10;
        buf /=10;
    }

    if (num == reversedNum)
    {
        return true;
    }

    return false;
}

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number))
{
    System.Console.WriteLine("Палиндром");
    return;
}

System.Console.WriteLine("Не палиндром");