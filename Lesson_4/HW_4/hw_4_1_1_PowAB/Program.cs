// Задача 1: Напишите цикл, который 
// принимает на вход два числа (А и В) и 
// возводит число А в натуральную степень В.
// 3, 5 -> 243 (З5
// 2, 4-> 16

int PowAB(int a, int b)
{
    int powAB = 1;
for (int i = 1; i <= b; i++)
{
    if(b>0) powAB *= a;
    
}
return powAB;
}
System.Console.WriteLine("Введите 2 числа - А и В,- для расчёта\nрезультата возведения А в степень В");
int.TryParse(Console.ReadLine(), out int A);
int.TryParse(Console.ReadLine(), out int B);

int result = PowAB(A, B);
Console.WriteLine(result);