// 3. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Введите число");
void find(int a)
{
    if ( a % 7 == 0 && a % 23 == 0)
    Console.WriteLine("кратно");
    else
    Console.WriteLine("не кратно");

}
find(int.Parse(Console.ReadLine()!));




