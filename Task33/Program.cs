/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

int Promt(string message)
{
    Console.Write(message);
    
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
}

bool FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }

    return false;
}

int[] array = CreateArrayRndInt(12, -9, 9);
int number = 0;

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

number = Promt("Введите число для поиска: ");

bool isNumberInArray = FindNumber(array, number);

if (isNumberInArray)
{
    Console.Write($"{number} ");
    Console.Write("[");
    PrintArray(array);
    Console.WriteLine("] -> да");
}
else
{
    Console.Write($"{number} ");
    Console.Write("[");
    PrintArray(array);
    Console.WriteLine("] -> нет");
}

