// Задача 2: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в пространстве.
// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1,-1) -> 7,21

Console.WriteLine("Введите кординаты двух точек - А и В.\n Вводить надо две координаты точки А через Enter, а затем точки В, тоже через Enter");
int Ax = QueryingAnumber();
int Ay = QueryingAnumber();
int Bx = QueryingAnumber();
int By = QueryingAnumber();

int QueryingAnumber(){
 Console.WriteLine("Введите координату и нажмите Enter");  
 return Int32.Parse(Console.ReadLine()!);
}

double SegmentLength(int ax, int ay, int bx, int by){
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by,2));
}
Console.WriteLine($"Длина отезка равна {SegmentLength(Ax, Ay, Bx, By)}");


// double ax = Double.Parse(Console.ReadLine()!);
// double ay = Double.Parse(Console.ReadLine()!);
// double bx = Double.Parse(Console.ReadLine()!);
// double by = Double.Parse(Console.ReadLine()!);