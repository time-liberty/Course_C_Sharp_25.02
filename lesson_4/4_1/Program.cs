// напишите программу, которая прнимает на вход
//число и выдает количество чифр в числе

int example(int num)
{
    int kol = 0;
    for (int i = 1; num > 0; i++)
    {
        num = num / 10;
        kol = i;
    }
    return kol;
}
int res = int.Parse(Console.ReadLine()!);
Console.WriteLine(example(res));

