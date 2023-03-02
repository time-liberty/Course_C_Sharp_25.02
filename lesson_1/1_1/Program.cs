// напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число кватратом второго.
Console.WriteLine("Введите чило a");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите чило b");
int b = int.Parse(Console.ReadLine()!);

if ( b * b == a ) 
{
    Console.WriteLine("число а является кватратом числа b");
}
else
{
    Console.WriteLine("число а не является кватратом числа b");
}


