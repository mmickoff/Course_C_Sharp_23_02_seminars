// 1. Напишите программу, которая принимает на вход координаты точки (X и Y) 
// причём X != 0 или Y != 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

string Quarters(int x, int y)
{
    if (x == 0 | y == 0) return ("... - нельзя ноль!");
    else if (x > 0 && y > 0) return ("I");
    else if (x < 0 && y > 0) return ("II");
    else if (x < 0 && y < 0) return ("III");
    else return ("IV");
}

void PrintOff(int x, int y)
{
    Console.WriteLine("Это четверть " + Quarters(x, y));
}

int QueryingOfNum()
{
    Console.WriteLine("Введите число для определения четверти");
    return (int.Parse(Console.ReadLine()!));
}
PrintOff(QueryingOfNum(), QueryingOfNum());
// Quarters(QueryingOfNum(), QueryingOfNum());