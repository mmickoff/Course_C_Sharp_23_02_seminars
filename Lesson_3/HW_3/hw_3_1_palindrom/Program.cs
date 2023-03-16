// Задача 1: Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432-> да
// 12821-> да

Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int number);

int reversNum = ReversNumber(number);
Ask(reversNum, number);
string Ask(int a, int b)
{
    if (a == b) return "Да!";
    return "Нет!";
}
int ReversNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
    return result;
}

Console.WriteLine(number + " -> " + Ask(reversNum, number));