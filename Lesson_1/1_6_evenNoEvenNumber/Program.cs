﻿// Задача 6: Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число");
double number = double.Parse(Console.ReadLine()!);
Console.Write(number + " -> ");
if (number % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");