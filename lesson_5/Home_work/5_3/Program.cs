//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
 

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, double from, double to)
{
    double[] arr = new double[size];
    Random rnd = new Random();


    for (double i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (from - to) + to;
    }
    return arr;
}
int poisk(int[] arr)
{
    int max = 0;
    int min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > i)
        {
            max = arr[i];
        }
        else if (arr[i] < i)
        {
            min = arr[i];
        }
    }
    int res = max - min;
    Console.WriteLine(res);
    return max;
    return min;
}
Console.WriteLine("Введите количество чисел цикла");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число начала цикла");
int Start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число конца цикла");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, Start, stop);
PrintArray(mass);
poisk(mass);