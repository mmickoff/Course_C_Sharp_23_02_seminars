// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт произведение чисел от 1 до А.


int MultiplyAllNum(int n)
{
    int multiAllNum = 1;
    for (int i = 2; i <= n; i++)
    {
        // int num = i + 1;
        multiAllNum *= i;
    }
    return multiAllNum;
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int result = MultiplyAllNum(N);
Console.WriteLine(result);