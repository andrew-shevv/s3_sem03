// Напишите программу, 
// которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Input five-digit number: ");
int num5dig = Convert.ToInt32(Console.ReadLine());

void StringSolution(){
    string num5string = num5dig.ToString();
    if (num5string.Length == 5){
        Console.WriteLine("Is this number a palindrome?");
        if (num5string[0] == num5string[4] && num5string[1] == num5string[3]){
            Console.WriteLine("yes");
        }
        else Console.WriteLine("no");
    }
    else Console.WriteLine("This isn't a five-digit number");
}

void MathSolution(){
    if (num5dig > 9999 && num5dig < 100000){
        Console.WriteLine("Is this number a palindrome?");
        if (num5dig % 10 == num5dig / 10000 && num5dig / 10 % 10 == num5dig / 1000 % 10){
            Console.WriteLine("yes");
        }
        else Console.WriteLine("no");
    }
    else Console.WriteLine("This isn't a five-digit number");
}

START:
Console.WriteLine("To do math solution input 1");
Console.WriteLine("To do string solution input 2");
int sol = Convert.ToInt32(Console.ReadLine());

if (sol == 1){
    MathSolution();
}
else if (sol == 2){
    StringSolution();
}
else {
    Console.WriteLine("Try again please");
    goto START;
}
