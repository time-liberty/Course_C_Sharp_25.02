//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
 

void PrintArray(double[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * (from + to) - from, 2);
        Console.WriteLine($"{arr[i]}");
    }
    return arr;
}
void poisk(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Max: {max}, min: {min}.  ");
    Console.WriteLine($"{max} - ({min}) = {Math.Round(max-min),2}");
}
Console.WriteLine("Введите количество чисел цикла");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число начала цикла");
int Start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число конца цикла");
int stop = int.Parse(Console.ReadLine()!);
double[] mass = MassNums(num, Start,stop);
PrintArray(mass);
poisk(mass);