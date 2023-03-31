// 2. Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void ValuesSet(int N,int M)
{
if (N == M) return;
ValuesSet(N, M-1);
Console.Write($"{M} ");
}
Console.WriteLine("Введите число начала");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число начала");
int num_1 = int.Parse(Console.ReadLine()!);
ValuesSet(num,num_1);