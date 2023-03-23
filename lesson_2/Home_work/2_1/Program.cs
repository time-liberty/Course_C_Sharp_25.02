// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int TakeNum(int num)
 {
    Console.WriteLine(num);
    int res = num /10;
    int res1= res % 10;
    Console.WriteLine(res1);
    return(res1);
 }

 int itog = TakeNum(new Random().Next(100, 1000));
