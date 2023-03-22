﻿//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size,int from, int to)
{
    int[] arr = new int[size];


    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next ( from, to);
    }
    return arr;
}
int SumNegPos(int[] arr)
{
    int sum = 0;
    for (int i =0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (arr.Length- i-1);
    }
    return arr;
}

Console.WriteLine("Введите количество чисел цикла");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число начала цикла");
int Start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число конца цикла");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, Start, stop);
PrintArray(mass);
SumNegPos(mass);
PrintArray(SumNegPos);