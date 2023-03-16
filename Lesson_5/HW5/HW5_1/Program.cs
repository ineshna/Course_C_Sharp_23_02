// Задайте массив заполненный случайными положительными трехзначными числами.
// напишите програаму, которая покажет количество четных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);


void FillArray(int[]collection)
{
    int length = collection.Length;
    int index= 0;
    while(index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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
int EvenPart(int[] array, int num)
{
    int alleven = 0;
    for(int i = 0; i < size; i++)
    {if (array[i] %2 == 0)
        alleven = alleven +1;
    }
    return alleven;

}
int[] array =  new int[size];
FillArray(array);
PrintArray(array);
EvenPart(array, size);
int result = EvenPart(array, size);
Console.WriteLine();
Console.Write($"В заданном массиве  {result} четных чисел");