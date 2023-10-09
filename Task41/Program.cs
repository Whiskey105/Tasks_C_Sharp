/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] ConverStringToIntArray(string numbers)
{
    string[] stringArray = numbers.Split(' ');
    int[] intArray = new int[stringArray.Length];
    int buff = 0;

    for (int i = 0; i < intArray.Length; i++)
    {
        bool success = int.TryParse(stringArray[i], out buff);
        if (success)
        {
            intArray[i] = Convert.ToInt32(stringArray[i]);
        }
        else
        {
            Console.WriteLine($"Попытка конвертации '{stringArray[i] ?? "<null>"}' провалена.");
        }
        if (int.TryParse("Ошибка ввода!!!", out buff))
        {
            return intArray;
        }

    }

    return intArray;

}

string PrintArray(int[] arr)
{
    string arrLine = "";

    for (int i = 0; i < arr.Length; i++)
    {
        arrLine += $"{arr[i]} ";
    }

    arrLine = arrLine.Remove(arrLine.Length - 1);

    return arrLine;
}

int CountPositiveNumbers(int[] arr)
{
    int result = 0;
    foreach (int item in arr)
    {
        if (item > 0) result++;
    }

    return result;
}

Console.WriteLine("Введите M целых чисел через пробел: ");

string line = Console.ReadLine();

if (line == "")
{
    Console.WriteLine("Вы не ввели числа!!!");
    return;
}

int[] array = ConverStringToIntArray(line);
int amountOfPositiveNumbers = CountPositiveNumbers(array);

System.Console.WriteLine($"{PrintArray(array)} -> {amountOfPositiveNumbers}");