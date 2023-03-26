// 2. Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.


string convert(int num_1)
{
    string res = "";
    while (num_1 > 0)
    {
        res = num_1 % 2 + res;
        num_1 = num_1 / 2;
    }
    return res;
}
Console.WriteLine(convert(12));



