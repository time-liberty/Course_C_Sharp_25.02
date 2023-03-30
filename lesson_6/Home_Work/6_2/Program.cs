//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void example(float k1,float b1, float k2 , float b2)
{
    if (k1==k2 && b1==b2)
    {
        Console.WriteLine("Прямы совпадают");
    }
    else if (k1==k2)
    {
        Console.WriteLine("прямые паралельны");
    }
    else
    {
        float x = (b2-b1)/(k1-k2);
        float y = k1*x+b1;
        Console.WriteLine($"x = {x} , y = {y}");
    }
}
Console.WriteLine("Введите число k1");
float k1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b1");
float b1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2");
float k2 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b2");
float b2 = float.Parse(Console.ReadLine()!);
example(k1,b1,k2,b2);