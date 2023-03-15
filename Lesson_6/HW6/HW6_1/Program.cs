// Пользователь вводит склавиатуры М чисел. Посчитайте,
// сколько чисел больше 0 ввел пользователь.

void FillArray(int[] collection)


{
    int lenthh = collection.Length;
    int index = 0;
    while (index < lenthh)
    {
        collection[index] = new Random().Next(-10, 10);
        index++;
    }
    int sum = 0;
    for (int i = 0; i < index; i++)
    {
        if (collection[i] > 0)
        {
            sum++;
        }

    }
    int result = sum;
    Console.Write("В массиве : ");
    Console.Write(sum);
    Console.WriteLine(" положительных чисел ");
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}



int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

