//Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int ValuesSet(int N,int M)
{
if (M < N) return 0;
ValuesSet(N, M-1);
return ValuesSet(N,M-1)+M;

}
Console.WriteLine("Введите число начала");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число начала");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValuesSet(num,num_1));