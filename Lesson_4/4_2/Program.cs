// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int MultiplyNum(int num)
{
    int multiply = 1;
    for (int i = 1; num >= i; i++)
        multiply *= i;
    return multiply;    
}

// Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int result = MultiplyNum(A);
Console.WriteLine(result);
