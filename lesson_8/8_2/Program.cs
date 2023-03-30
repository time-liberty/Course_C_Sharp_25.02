// 3. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных. Значения элементов массива 0..9
//

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]} ");
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
            arr[i, j] = new Random().Next(from, to);
        }
    return arr;
}

int[] Vocab(int[,] arr)
{
   int[] arr_new = new int[10];
   foreach(int a in arr) arr_new[a]++;
   return arr_new;
}
void Print(int[] arr)
{
     for (int i = 0; i < arr.Length; i++)
    {
         Console.Write($"{i}-{arr[i]} ");
    }
    Console.WriteLine();
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
Print(Vocab(mass));