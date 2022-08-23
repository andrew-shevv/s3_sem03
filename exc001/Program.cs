// Напишите программу,
// которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Input x coord: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coord: ");
int ya = Convert.ToInt32(Console.ReadLine());

if (xa > 0 && ya > 0){
    Console.WriteLine("Quarter I");
}
else if (xa < 0 && ya > 0){
    Console.WriteLine("Quarter II");
}
else if (xa < 0 && ya < 0){
    Console.WriteLine("Quarter III");
}
else if (xa > 0 && ya < 0){
    Console.WriteLine("Quarter IV");
}
else Console.WriteLine("One/both of the coords is/are not on any of the quarters");