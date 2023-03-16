// Задача 3: Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5-> 1, 4, 9,16,25.
// 2 -> 1,4

Console.WriteLine("Введите число для вычисления:");
int number = int.Parse(Console.ReadLine()!);
void SquareOfTheNmber(int num){
    int i = 1;
    while (i <= num){
Console.Write(Math.Pow(i, 2) + " ");
i++;
    }
}
SquareOfTheNmber(number);