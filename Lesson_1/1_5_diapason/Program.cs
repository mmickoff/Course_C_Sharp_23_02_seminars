// Task 1_5_diapason
// 5. Напишите программу, которая 
// на вход принимает одно число (N), а 
// на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0,1, 2, 3, 4" а
// 2 -> " -2, -1, 0,1, 2"

Console.WriteLine("Введите целое число");
int num = int.Parse(Console.ReadLine()!);
if (num < 1) Console.WriteLine("Не корректный ввод");
else
{
    Console.Write($"{num} -> \"");
    int minusNum = 0 - num;
    while (minusNum <= num)
    {
        Console.Write(minusNum);
        if (minusNum != num) Console.Write(", ");
        else Console.WriteLine("\"");
        minusNum++;
    }
}