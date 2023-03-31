// 2. Задайте двумерный массив. Найдите элементы,
// у которых обе позиции чётные, и замените эти элементы на их квадраты.


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
void DoubNum(int[,] array)
{
    for(int i = 1; i < array.GetLength(0); i+=2)
    {
        for(int j = 1; j < array.GetLength(1); j+=2)
        {
            array[i,j] = array[i,j] * array[i,j];
        }
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
DoubNum(mass);
PrintArray(mass);