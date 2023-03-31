// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.


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
string SumNum(int[,] array,int num)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == num)
            {
                return $"{i+1} {j+1}";
            }
        }
    }
    return "такого значенния нет";
}
Console.WriteLine("Введите количество строк");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало цикла");
int Start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец массива");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите чиссло которое необходмо найти");
int num = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(num_row, num_column, Start, stop);
PrintArray(mass);
string sum = SumNum(mass,num);
Console.WriteLine(sum);