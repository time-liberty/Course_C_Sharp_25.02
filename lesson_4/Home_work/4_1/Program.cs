// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.;

int SunNum(int a , int b )
{
    int sum = 1;
    for (int i = 1; i <= b ; i++)
    {
        sum = sum * a ;
        Console.WriteLine(sum);
    }
    return a;
}


int sum_1 = int.Parse(Console.ReadLine()!);
int sum_2 = int.Parse(Console.ReadLine()!);
SunNum(sum_1, sum_2);