// 17. Напишите программу, которая принимает 

// 1. на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта
// точка.

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    
    return 0;
}

Console.WriteLine("Введите координаты точек");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);

string result = quarter > 0 
                            ? $"Указанные координаты ({xCoordinate};{yCoordinate}) соответсвуют {quarter} четверти" 
                            : "Введены некорректные координаты";


Console.WriteLine(result);