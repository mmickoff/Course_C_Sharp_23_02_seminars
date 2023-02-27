// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), а 
// 2. на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число:");
int number = int.Parse(Console.ReadLine()!);
Console.Write(number + " -> ");
int n = 2;
// while (n <= number)
do
{
    if (n % 2 == 0)
    {
        Console.Write(n);
    if (n < number -1 /* && n % 2 == 0 */)
        Console.Write(", ");
    }
    n+=2;
}while (n <= number);