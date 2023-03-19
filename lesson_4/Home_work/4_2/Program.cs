// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int example(int num)
{
    int res_1 = 0;
    int res = 0;
    for( int i =1 ; i < num; i++)
    {
        res += num % 10;
        num = num / 10;
        res_1 = res + num;
        Console.WriteLine(res_1);
    }
    return num;
}

int A = int.Parse(Console.ReadLine()!);
int result = example(A);

