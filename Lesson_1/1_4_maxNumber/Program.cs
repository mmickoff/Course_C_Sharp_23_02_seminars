// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



Console.WriteLine("Введите три числа для сравнения.\nВведите первое число:");
double num1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
double num2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число:");
double num3 = double.Parse(Console.ReadLine()!);
Console.Write($"{num1} {num2} {num3} -> ");
if (num1 == num2 || num2 == num3 || num3 == num1) Console.WriteLine("Некорректный ввод. Начните сначала и введите разные числа");
else
{
    double max = num1;
    if(num1 < num2) max = num2;
    if(num2 < num3) max = num3; 
    Console.WriteLine(max);
}
