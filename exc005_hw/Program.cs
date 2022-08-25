// Напишите программу, 
// которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Input five-digit number: ");
int num5dig = Convert.ToInt32(Console.ReadLine());

if (num5dig > 9999 && num5dig < 100000){
    Console.WriteLine("Is this number a palindrome?");
    if (num5dig % 10 == num5dig / 10000 && num5dig / 10 % 10 == num5dig / 1000 % 10){
        Console.WriteLine("yes");
    }
    else Console.WriteLine("no");
}
else Console.WriteLine("This isn't a five-digit number");