// Задача 3: Напишите программу, которая 
// задаёт массив из 8 элементов случайными числами и 
// выводит их на экран. 
// Оформите заполнение массива и 
// вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1


void FillArray(int[] arr, int startArr, int endArr, int lenArr)
// чего-то у меня какой-то наворот с аргументами получился
// пришлось вводить в аргументы массив, т.к. без него отказывается его считать
// хотел обойтись только масиивом, но куда тогда втыкать запрашиваемые параметры???
{
    // int[] arr = new int[lenArr];
    for (int i = 0; i < lenArr; i++)
    {
        arr[i] = new Random().Next(startArr, endArr);
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
}

Console.WriteLine("Введите диапазон чисел, заполняющих массив - от нижего до верхнего предела,-и его размер. Начинайте с нижнего значения, потом верхнее, и затем размер массива:");
int.TryParse(Console.ReadLine(), out int startArray);
int.TryParse(Console.ReadLine(), out int endArray);
int.TryParse(Console.ReadLine(), out int lengthArr);
// int startArray = int.Parse(Console.ReadLine()!);
// int endArray = int.Parse(Console.ReadLine()!);
// int lengthArr = int.Parse(Console.ReadLine()!);
// int startArray = Console.ReadLine();
// int endArray = Console.ReadLine();
// int lengthArr = Console.ReadLine();

// ЭКСПЕРИМЕНТИРОВАЛ, Т.К. ERROR  НА ВСЕ ТРИ СТРОЧКИ ВЫДАВАЛО

int[] arr = new int[lengthArr];

FillArray(arr, startArray, endArray, lengthArr);
PrintArray(arr);
