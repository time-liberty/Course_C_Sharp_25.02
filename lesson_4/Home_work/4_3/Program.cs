// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = { 1, 1, 2,4,1,123,12,31};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++ )
        {
            if(array[j] < array[minPosition]) minPosition = j;

        }
        int temporary = array[i];
        array[i] =array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);



