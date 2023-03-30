// напишите программу , которая принимает на вход число N
// и выдает произведение чисел от 1 до N.

int example(int n)
{
    if (n == 1) 
    {
        return 1 ;
    }
    else
    {
       return n * example(n - 1);
    }
}
Console.WriteLine(example(5));