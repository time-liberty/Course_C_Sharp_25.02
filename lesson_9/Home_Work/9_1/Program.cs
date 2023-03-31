//Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"
void ValuesSet(int N, int M)
{
    if (M < N) return;
    if (M % 2 == 0)
    Console.Write($" {M} ");
    ValuesSet(N, M - 1);
    ValuesSet(N, M);
    return;
}
Console.WriteLine("Введите число начала");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число конца");
int num_1 = int.Parse(Console.ReadLine()!);
ValuesSet(num, num_1);