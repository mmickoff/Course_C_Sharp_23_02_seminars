
// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно


Console.WriteLine("Введите первое число:");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
double b = double.Parse(Console.ReadLine()!);
Console.Write($"{a}, {b} -> ");
Div(a, b);

void Div(double num1, double num2)
{
    if (num1 % num2 == 0) Console.WriteLine("Кратно");
    else Console.Write($"Не кратно, остаток {num1 % num2}");
}