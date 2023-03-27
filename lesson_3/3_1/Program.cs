// // 1. Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)
Console.WriteLine("Введите номер зоны");
void Quartes(int num)
{
    if (num ==1)
    {
        Console.WriteLine(" x > 0, y > 0 ");
    }
    if (num ==2)
    {
        Console.WriteLine(" x < 0, y > 0 ");
    }

    else if (num ==3)
    {
        Console.WriteLine(" x < 0, y < 0 ");
    }
    else if (num ==4)
    {
        Console.WriteLine(" x > 0, y < 0 ");
    }
    else if (num > 4)
    {
        Console.WriteLine("ERROR");
    }
}
int num_1 = int.Parse(Console.ReadLine()!);
Quartes(num_1);

