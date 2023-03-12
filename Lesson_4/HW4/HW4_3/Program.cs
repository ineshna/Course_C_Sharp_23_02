// Напишите программу, которая задаёт массив из 8 элементов случайными числами
// и выводит их на экраню Оформите заполнение массива и вывод в виде функции.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение массива: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальноезначение массива: ");
int end = int.Parse(Console.ReadLine()!);

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index= 0;
    while(index < length)
    {
        collection[index] = new Random().Next(start, end);
        index++;
    }


}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array =  new int[size];
FillArray(array);
PrintArray(array);