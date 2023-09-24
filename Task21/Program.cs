double Distance (int[] pointA, int[] pointB)
{
    
    double result = Math.Sqrt((pointA[0]-pointB[0])*(pointA[0]-pointB[0])+(pointA[1]-pointB[1])*(pointA[1]-pointB[1])+(pointA[2]-pointB[2])*(pointA[2]-pointB[2]));
    return result;
}

int [] arrayA = new int [3];
Console.WriteLine("Введите координаты точки A: ");
Console.Write("X1: ");
arrayA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
arrayA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
arrayA[2] = Convert.ToInt32(Console.ReadLine());

int [] arrayB = new int [3];
Console.WriteLine("Введите координаты точки B: ");
Console.Write("X2: ");
arrayB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
arrayB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
arrayB[2] = Convert.ToInt32(Console.ReadLine());

double result = Distance(arrayA, arrayB);

Console.WriteLine($"A ({arrayA[0]}:{arrayA[1]}:{arrayA[2]}); B ({arrayB[0]}:{arrayB[1]}:{arrayB[2]})-> {Math.Round(result, 2, MidpointRounding.ToZero)}");