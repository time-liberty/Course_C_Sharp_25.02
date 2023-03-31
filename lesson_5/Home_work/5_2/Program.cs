//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size,int from, int to)
{
    int[] arr = new int[size];


    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next ( from, to);
    }
    return arr;
}
int SumNegPos(int[] arr)
{
    int sum = 0;
    for (int i =0; i < arr.Length; i+=2)
    {
        if ( i % 2 == 0)
        {
            sum = sum + arr[i];
        }
    }
    Console.WriteLine(sum);
    return sum;
}

Console.WriteLine("Введите количество чисел цикла");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число начала цикла");
int Start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число конца цикла");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, Start, stop);
PrintArray(mass);
SumNegPos(mass);