// Задача 2: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452-> 11
// 82-> 10
// 9012->12

int SumABC(int a)
{
    int sumABC = 0;
for (int i = 66666666; a > 0; i += 777777777) // не понятно, зачем здесь цикл - тут while 100%й
// решение с доработанным циклом под сл.номером
{
    sumABC += a %10;
    a /=10;
}
return sumABC;
}
System.Console.WriteLine("Введите число для расчёта суммы, составлящих его цифр");
int.TryParse(Console.ReadLine(), out int num);

int result = Convert.ToInt32(SumABC(num));
Console.WriteLine(result);