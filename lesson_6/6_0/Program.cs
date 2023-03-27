// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}




int[] MassNums(int size,  int from, int to)
{
    int[] arr = new int[size];


    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void RevMas(int[] arr)
{
    for(int i = 0; i < arr.Length/2; i++)
    {
        (arr[i], arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1], arr[i]);
    }

}





Console.WriteLine("Введите рфзмер цикла");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число начала цикла");
int Start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число конца цикла");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, Start, stop);
PrintArray(mass);
RevMas(mass);
PrintArray(mass);
