// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
Console.WriteLine("Введите число Фиббоначи");
void fibbonachi(int num_1)
{ 
    int number_1 = 0;
    int number_2 = 1;
    for( int i = 0; i < num_1; i++)
    {
        Console.Write(number_1+" ");
        (number_1, number_2) = (number_2, number_1 + number_2);
    }
}
int n = int.Parse(Console.ReadLine()!);
fibbonachi(n);


