// 01. Напишите программу, которая 
// 1. на вход принимает два
// числа,
// 2.  второе чоисло возводит в квадрат,
// 3. проверяет, является-ли первое число квадратом
// второго.
// а = 25, b = 5 -> да 
// а = 2, b = 10 -> нет 
// а = 9, b = -3 -> да 
// а = -3 b = 9 -> нет

Console.WriteLine("Необходимо ввести два числа. Введите первое число");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторвое число");
double num2 = double.Parse(Console.ReadLine());
double square = /* double.Parse( */Math.Pow(num2, 2)/* ) */;
if (num1 == square) Console.WriteLine($"a = {num1}, b = {num2} -> да");
else {Console.WriteLine($"a = {num1}, b = {num2} -> нет");}