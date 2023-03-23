// Task_23_01_cubeOfNumber
// Задача 23: Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// 3->1, 8,27
// 5 -> 1, 8, 27, 64,125

void CubeOfNumber2(int n)
{
    double[] cubes = new double[n];
    for (int i = 0; i < n; i++)
    {
        cubes[i] = Math.Pow((i + 1), 3);
        Console.Write(cubes[i]);
        if(i < n - 1) Console.Write(", ");
    }
}
// int n;
System.Console.WriteLine("Введите число для вычисления: ");
int n = int.Parse(Console.ReadLine()!);
CubeOfNumber2(n);