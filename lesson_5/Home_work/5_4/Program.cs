//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


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
int[] SumNegPos(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for (int i =0; i < size / 2; i++)
    {
        new_arr[i] = arr[i] * (size - i - 1);

        if(size % 2 == 1)
        {
            new_arr[flex_size - 1] = arr[size / 2];
        }

    }
    return new_arr;
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