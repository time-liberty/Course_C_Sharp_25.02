// 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.


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

void SumPosNeg(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = - arr[i];       
    }

}
int num = int.Parse(Console.ReadLine()!);
int Start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, Start, stop);
PrintArray(mass);
SumPosNeg(mass);
PrintArray(mass);



