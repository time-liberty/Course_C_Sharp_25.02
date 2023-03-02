// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите числа из которых необходимо найти максималльное");
Console.WriteLine("Ведите число а");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите число b");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите число c");
int c = int.Parse(Console.ReadLine()!);

if ( a < b )
{
    if ( b < c )
    {
        Console.WriteLine("max = c ");
    }
    else
    {
        Console.WriteLine(" max = b ");
    }

}
else if ( a < c )
{
    Console.WriteLine("max = c");
}
else if ( a > c )
{
    Console.WriteLine("max = a");
}