// Задача 4: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, соответствующую дню недели");
// int numberOfDay = int.Parse(Console.ReadLine()!);
// int numOfWeekDay = numberOfDay;
int day = 0;

int WeekDay(int numberOfDay){
bool checkDay = false;
while (checkDay == false){
numberOfDay = int.Parse(Console.ReadLine()!);
if (numberOfDay < 1 | numberOfDay > 7) {
    Console.WriteLine ("Некорректный ввод - введите заново:");
    checkDay = false;
    }else{checkDay = true;}}
return numberOfDay; }

string FindDay(int numOfDay){
    switch (numOfDay){
        case 6: return "Да";
        case 7: return "Да";
       default: return "Нет";
    }
}
int weekDay = WeekDay(day);
Console.WriteLine($"{weekDay} -> {FindDay(weekDay)}");