// Задача 3: Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое целое число:");
int number = int.Parse(Console.ReadLine()!);
Console.Write($"{number} -> ");
if (number < 100) Console.WriteLine("третьей цифры нет");
else Console.WriteLine(ThirdNumber(number));

int ThirdNumber(int num){
while (num > 999){
    num = num/10;
}
return num%10;

}
