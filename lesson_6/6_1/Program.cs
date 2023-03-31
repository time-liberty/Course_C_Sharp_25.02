// 1. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

void triugle(int a, int b, int c)
{
    if (a<b+c && b<a+c && c < b+a)
    Console.WriteLine("yes");
    else
    Console.WriteLine("no");
}
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
int num_3 = int.Parse(Console.ReadLine()!);
triugle(num_1, num_2, num_3);
