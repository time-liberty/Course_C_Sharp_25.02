//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int Prompt(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int Length)
{
    int[] array = new int[Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"a[{i}] = {array[i]}");
    }
    return array;
}
int SumPosNum(int[] array)
{
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            res = res + 1;
        }
    }
    return res;
}
Console.WriteLine("Введите длину цикла");
int Length = Convert.ToInt32(Console.ReadLine()!);
int[] array;
array = MassNums(Length);
PrintArray(array);
Console.WriteLine($"{SumPosNum(array)}");




