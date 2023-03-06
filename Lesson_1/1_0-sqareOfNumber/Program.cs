// Task_1_0
// 0. Демонстрация решения
// Напишите программу, которая 
// 1. на вход принимает число 
// 2. выдаёт его квадрат (число умноженное на само себя).
// Например: 4-> 16 -3-> 9 -7-> 49

Console.WriteLine("Введите число");
double number = double.Parse(Console.ReadLine()!);
Console.WriteLine(Math.Pow(number, 2));
