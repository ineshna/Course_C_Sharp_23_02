// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элеентов, стоящих на нечетных позициях.
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);


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
int EvenIndex(int[] array, int num)
{
    int sumindex = 0;
    for(int i = 0; i < size; i = i+2)
        
        sumindex += array[i];
    
    return sumindex;

}
int[] array =  new int[size];
FillArray(array);
PrintArray(array);
EvenIndex(array, size);
int result = EvenIndex(array, size);
Console.WriteLine();
Console.Write($"Cумма элементов на нечетных позициях равна {result} ");
