// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Input number: ");
int numN = Convert.ToInt32(Console.ReadLine());

for (double i = 1; i <= numN; i++){
    double count = Math.Pow(i, 3);
    Console.Write($"{count} ");
}