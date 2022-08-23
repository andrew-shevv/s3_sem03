// Напишите программу,
// которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Input coord x of first point");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coord y of first point");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coord x of second point");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coord y of second point");
double yb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

Console.WriteLine($"Distance between points: {distance:f3}");