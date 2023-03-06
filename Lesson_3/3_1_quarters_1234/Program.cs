// 1. Напишите программу, которая принимает на вход координаты точки (X и Y) 
// причём X != 0 или Y != 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

void Quarters(int x, int y){
    if (x == 0 | y ==0) Console.WriteLine("Некорректный ввод");
    else if (x > 0 && y > 0) Console.WriteLine("I");
    else if (x < 0 && y > 0) Console.WriteLine("II");
    else if (x < 0 && y < 0) Console.WriteLine("III");
    else Console.WriteLine("IV");
}

// string PrintOff($"Это четверть {}")

int QueryingOfNum(){
  Console.WriteLine("Введите число для определения четверти");
  return(int.Parse(Console.ReadLine()!));  
}

 Quarters(QueryingOfNum(), QueryingOfNum());
