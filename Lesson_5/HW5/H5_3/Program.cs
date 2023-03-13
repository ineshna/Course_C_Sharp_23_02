// Задайте  массив вещественных чисел.Найдите разницу между ,
// максимальным и минимальным элементом массива.
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

//Console.Write("Введите минимальное значение массива: ");
//int start = int.Parse(Console.ReadLine()!);

//Console.Write("Введите максимальноезначение массива: ");
//int end = int.Parse(Console.ReadLine()!);

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index= 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }


}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}  ");
        position++;
    }
}
int MaxNum(int[] array, int num)
{
    int max = array[0];
    for(int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
        
    return max;

}

int MinNum(int[] array, int num)
{
    int min = array[0];
    for(int i = 0; i < size; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
        
    return min;

}
int[] array =  new int[size];
FillArray(array);
PrintArray(array);
MaxNum(array, size);
int resultmax = MaxNum(array, size);
Console.WriteLine();
Console.WriteLine($"максимум равен {resultmax} ");
MinNum(array, size);
int resultmin = MinNum(array, size);
Console.WriteLine();
Console.WriteLine($"минимум равен {resultmin} ");
Console.WriteLine();
Console.WriteLine($"сумма максимума и минимума равна {resultmin +resultmax } ");