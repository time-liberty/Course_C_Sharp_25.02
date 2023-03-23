// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];


    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}
Console.WriteLine("Введите число которое необходимо найти");
int number = int.Parse(Console.ReadLine()!);

void poisk(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            Console.WriteLine("yes");
            return;
        }
    }
    Console.WriteLine("no");
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