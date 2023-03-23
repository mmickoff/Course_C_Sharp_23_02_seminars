// Задача 3: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Massive(int num)
{int[] array = new int[num];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(2);
  Console.Write(array[i]);
    if (i < array.Length - 1) Console.Write(", ");
}}

Console.WriteLine("Введите длину массива:");
int.TryParse(Console.ReadLine(), out int number);
Massive(number);