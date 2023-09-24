using System.Text.RegularExpressions;
using System;
/* Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

double Distance (int x1, int x2, int y1, int y2)
{
    
    double result = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return result;
}
Console.WriteLine("Введите координаты точки A: ");
Console.Write("X1: ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X2: ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());

double result = Distance(xACoordinate, xBCoordinate, yBCoordinate, yACoordinate);

Console.WriteLine($"A ({xACoordinate}:{yACoordinate}); B ({xBCoordinate}:{yBCoordinate})-> {Math.Round(result, 2, MidpointRounding.ToZero)}");
