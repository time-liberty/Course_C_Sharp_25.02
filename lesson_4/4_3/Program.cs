// 3. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

void massiv(int leght)
{
    int[] arr = new int[leght];
    for(int i = 0 ; i < leght; i++)
    {
        arr[i] = new Random().Next(2);
        Console.WriteLine(arr[i]);
    }
}
massiv(int.Parse(Console.ReadLine()!));