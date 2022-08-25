// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Input coord x of first point");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coord y of first point");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coord z of first point");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Input coord x of second point");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coord y of second point");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coord z of second point");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Distance between points: {distance:f3}");