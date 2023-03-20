// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.



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
int num = int.Parse(console.ReadLine()!);
int Start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = EightMass(num, Start, stop);
Print(mass);
