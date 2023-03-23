// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4-> 10
// 8-> 36

int SumOfRange(int n)
{
    int sumAllNum = 0;
    for (int i = 1; i <= n; i++)
    {
        // int num = i + 1;
        sumAllNum += i;
    }
    return sumAllNum;
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int result = SumOfRange(N);
Console.WriteLine(result);