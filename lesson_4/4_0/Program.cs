﻿// напишите программу которая принимает 
// на вход число (А) и выдает сумму чисел от 1 до А.
Console.WriteLine("Введите число");
int SunNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
    {
        all_sum += i;
    }
    return all_sum;
}
int A = int.Parse(Console.ReadLine()!);
int result = SunNum(A);
Console.WriteLine(result);