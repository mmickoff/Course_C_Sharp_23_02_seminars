// Задача 2: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452-> 11
// 82-> 10
// 9012->12

// int SumABC(int a)
// {
//     int sumABC = 0;
//     for (int i = a; a > 0; a /= 10) // не понятно, зачем здесь цикл - тут while 100%й
//                                     // решение с доработанным циклом под сл.номером
//         sumABC += a % 10;
//     return sumABC;
// }
// System.Console.WriteLine("Введите число для расчёта суммы, составлящих его цифр");
// int.TryParse(Console.ReadLine(), out int num);

// Второй вариант решения:

int SumNums_l(int num)
{
    int n_sum = 0;
    while (num > 0)
    {
        n_sum += num % 10;
        num /= 10;
    }
    return n_sum;
}
int num_l = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums_l(num_l));

int result = Convert.ToInt32(SumABC(num));
Console.WriteLine(result);

// Третий вариант решения:
// подробнее на https://shwanoff.ru/char-c-sharp/

int DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;
    for (int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]);
        sum += m;
    }
    return sum;
}
int n = int.Parse(Console.ReadLine()!); ;
Console.WriteLine(DigitSum(n));