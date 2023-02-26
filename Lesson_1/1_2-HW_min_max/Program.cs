// Задача 2: Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа. Сначала введите первое число:");
double num1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
double num2 = double.Parse(Console.ReadLine()!);
Console.Write($"a = {num1}; b = {num2} -> ");
double max = 0;
if (num1 == num2) Console.WriteLine("Числа равны. Начните заново и введите разные числа.");
else if (num1 > num2) { max = num1; PrintResult(max); }
else { max = num2; PrintResult(max); }

void PrintResult(double max1)
{
    Console.WriteLine("max = " + max1);
}


