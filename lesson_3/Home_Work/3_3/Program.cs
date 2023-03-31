// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void TakeNum(int size)
{
    int[] arr = new int[size];
    if (arr[0]==arr[4] || arr[1]==arr[3])
    Console.WriteLine("Является полидромом");
   else
     Console.WriteLine("не является полидромом");
}
Console.WriteLine("Введите число для проверки");
int start = int.Parse(Console.ReadLine()!);
TakeNum(start);