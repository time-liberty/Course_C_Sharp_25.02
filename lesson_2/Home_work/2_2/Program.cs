// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет


int TakeNum(int num)
{
    Console.WriteLine(num);
    if ( num<100 )
    {
        Console.WriteLine("третьей цифры нет");
        return(num);
    }
    else if (num>100 && num<1000)
    {
        int res1 = num % 10;
        Console.WriteLine(res1);
        return(res1);
    }
    else if (num>1000 && num<10000)
    {
        int res2 = num / 10;
        int res3 = res2 % 10;
        Console.WriteLine(res3);
        return(res3);
    }
    else if (num>10000 && num <100000)
    {
        int res4 = num / 100;
        int res5 = res4 % 10;
        Console.WriteLine(res5);
        return(res5);
    }
    return(num);

}
int res = TakeNum(new Random().Next(10, 100000)!);
