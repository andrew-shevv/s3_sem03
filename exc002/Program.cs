// Напишите программу,
// которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Input coord quarter number:");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1){
    Console.WriteLine("x = (0; +infinity)");
    Console.WriteLine("y = (0; +infinity)");
}
else if (quarter == 2){
    Console.WriteLine("x = (-infinity; 0)");
    Console.WriteLine("y = (0; +infinity)");
}
else if (quarter == 3){
    Console.WriteLine("x = (-infinity; 0)");
    Console.WriteLine("y = (-infinity; 0)");
}
else if (quarter == 4){
    Console.WriteLine("x = (0; +infinity)");
    Console.WriteLine("y = (-infinity; 0)");
}
else Console.WriteLine("This number isn't a coord quarter");
