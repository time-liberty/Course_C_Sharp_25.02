// напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X неравно нулю или Y неравно нулю и выдыет номер четверти 
// плоскости, в которой находится эта точка.


void Quartes(int x, int y)
{
    if ( x == 0 || y == 0 )
        Console.WriteLine("x == 0, y == 0");
    else if ( x > 0 && y > 0)
        Console.WriteLine("1");
    else if ( x < 0 && y > 0 )
        Console.WriteLine("2");
    else if ( x < 0 && y < 0)
        Console.WriteLine("3");
    else if ( x > 0 && y < 0 )
        Console.WriteLine("4");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quartes(num_1, num_2);