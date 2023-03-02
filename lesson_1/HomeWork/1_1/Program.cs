// 1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите числа которые небходимо сравнить");
Console.WriteLine("Ведите число а");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()!);

if ( a < b )
{
    Console.WriteLine("max = b");
}
else if ( a == b )
{
    Console.WriteLine("они равны");
}
else if ( a > b )
{
    Console.WriteLine("max = a ");
}

