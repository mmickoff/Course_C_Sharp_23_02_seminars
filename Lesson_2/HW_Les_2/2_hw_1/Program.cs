// Задача 1: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine()!);
if (number < 100 | number > 999) Console.WriteLine("Не корректный ввод. Введите число в соответствии с условием.");
else {Console.Write($"{number} -> ");
Console.WriteLine(SecondNumber(number));}

int SecondNumber(int num)
{
    return num / 10 % 10;
}
