// Task_21_01_distance3D_xyz
// Задача 21: Напишите программу, которая 
// 1. принимает на вход координаты двух точек 
// 2. находит расстояние между ними в 3D пространстве.
// А (3,6,8); В (2,1,-7), -> 15.84
// А (7,-5, 0); В (1,-1,9) -> 11.53

Console.WriteLine("Введите кординаты двух точек - А и В.\nВводить надо три координаты точки А через Enter,\nа затем три координаты точки В, тоже через Enter.");
int Ask(){
Console.WriteLine("Dводите координату");
return int.Parse(Console.ReadLine()!);
}

int ax = Ask();
int ay = Ask();
int az = Ask();
int bx = Ask();
int by = Ask();
int bz = Ask();

double distanceBetweenPoints = SegmentLength(ax, ay, az, bx, by, bz);

Console.WriteLine(Math.Round(distanceBetweenPoints, 2/* , MidpointRounding.ToZero */));

double SegmentLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
     
}