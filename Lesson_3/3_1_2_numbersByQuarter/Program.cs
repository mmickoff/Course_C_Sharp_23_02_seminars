// Задача 3_1: Напишите программу, которая 
// по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (х и у).

string rangeOfNumbersByQuarter(int quarter)
{
    string result;
    if (quarter == 1) result = "y > 0 & x > 0";
    else if (quarter == 2) result = "y > 0 & x < 0";
    else if (quarter == 3) result = "y < 0 & x < 0";
    else if (quarter == 4) result = "y < 0 & x > 0";
    else result = "... хмм... это вообще-то некорректный ввод";

// switch (quarter){
//     case 1: result = "y > 0 & x > 0";
//     // breake;
//     case 2: result = "y > 0 & x < 0";
//     // breake;
//     case 3: result = "y < 0 & x < 0";
//     // breake;
//     case 4: result = "y < 0 & x > 0";
//     // breake;
//     default: result = "Некорректный ввод";
//     // breake;
// }
return result;
    // if (quarter == 0) Console.WriteLine ("Некорректный ввод");
    // if 
}
int queryingTheNumber()
{
    Console.WriteLine("Введите номер честверти поля - от 1 до 4х включительно");
    int numOfQuarter = int.Parse(Console.ReadLine()!);
    return numOfQuarter;
}
int num = queryingTheNumber();
// rangeOfNumbersByQuarter(queryingTheNumber);
Console.WriteLine($"В четверти {num} координаты таковы - {rangeOfNumbersByQuarter(num)}");