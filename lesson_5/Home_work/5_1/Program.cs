//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];


    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}
int filtr(int[] arr)
{
    int num_1 = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if  ( arr[i] % 2 ==0)
        {
            num_1++;
        }
    }
    Console.WriteLine(num_1);
    return num_1;
}
Console.WriteLine("Введите количество чисел цикла");
int num = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num);
PrintArray(mass);
filtr(mass);