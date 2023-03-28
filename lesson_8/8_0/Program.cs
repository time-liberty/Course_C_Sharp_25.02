//задайте двумерный массив. Напишите программу
// которая поменяет местами первую и последнюю строку массива.

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];


    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = new Random().Next(from, to);
        }
    return arr;
}

void firstWithemLast(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for(int j = 0; j < column; j++)
    {
        (arr[0,j],arr[row - 1,j]) = (arr[row - 1,j],arr[0,j]);
    }
}
Console.WriteLine("Введите количество строк");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало цикла");
int Start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец массива");
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(num_row, num_column, Start, stop);
PrintArray(mass);
firstWithemLast(mass);
PrintArray(mass);