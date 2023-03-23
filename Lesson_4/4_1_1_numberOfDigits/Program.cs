int LengthNum(int num)
{
    // int lengthNum = 0;
    int a = 0;
    // for (int i = 1; num > 0; i++)
    while(num>0)
    {
        num = num / 10;
        // lengthNum = i;
        a++;
    }
    return a;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = LengthNum(num);
Console.WriteLine(result);
