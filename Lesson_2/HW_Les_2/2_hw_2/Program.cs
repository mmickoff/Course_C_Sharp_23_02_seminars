// Задача 2: Напишите программу, которая 
// выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



 
int result = DelSecondDigit(new Random().Next(100, 1000));
Console.WriteLine($" -> {result}");

int DelSecondDigit(int num)
{
    Console.Write(num);
    // int num1 = ;
    // int num2 = num % 10;
    return num / 100 *10 + num % 10;
}