﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void example(int num)
{
    for(int i = 1; i <= num; i++ )
    {
        Console.Write(i * i * i  + ", ");

    }
}
int num_1 = int.Parse(Console.ReadLine()!);
example(num_1);