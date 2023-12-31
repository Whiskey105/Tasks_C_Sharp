﻿// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray (int[] arr)
{   
    Random randNum = new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randNum.Next(0,2);
    }

}

string Message (int[] arr)
{
    string result = "[";

    foreach (int item in arr)
    {
        result += $"{item},";
    }

    result = result.Remove(result.Length - 1);
    result += "]";
    return result;
}

int[] array = new int[8];

FillArray(array);
System.Console.WriteLine(Message(array));


