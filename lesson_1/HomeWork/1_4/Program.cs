﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int b = 2; 

if ( 2 < a)
{
    while ( b <= a )
    {
        Console.Write( b + " ");
        b = b + 2;
    }
}
