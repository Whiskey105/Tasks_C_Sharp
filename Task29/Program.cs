/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] ConverStringToIntArray(string numbers)
{
    string[] stringArray = numbers.Split(' ');
    int[] intArray = new int[stringArray.Length];
    int buff = 0;

    for (int i = 0; i < intArray.Length; i++)
    {
        bool success = int.TryParse(value, out number);
        if (success)
        {
            intArray[i] = Convert.ToInt32(stringArray[i]);
        }
        else
        {
            Console.WriteLine($"Попытка конфертации '{value ?? "<null>"}' failed.");
        }
        if (int.TryParse("Ошибка ввода!!!", out j))
        {
            return new int { -1 };
        }
        
    }

    return intArray;

}

string PrintArray(int[] arr)
{
    string arrLine = "";

    for (int i = 0; i < arr.Length; i++)
    {
        arrLine += $"{arr[i]},";
    }

    arrLine = arrLine.Remove(arrLine.Length - 1);

    return arrLine;
}

Console.WriteLine("Введите 8 целых чисел через пробел: ");

string line = Console.ReadLine();

if (line == "")
{
    Console.WriteLine("Вы не ввели числа!!!");
    return;
}

int[] array = ConverStringToIntArray(line);

Console.WriteLine($"{PrintArray(array)} -> [{PrintArray(array)}]");

