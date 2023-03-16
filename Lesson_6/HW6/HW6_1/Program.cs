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


int Check(int num)
{
int count = 0;

    for( int i =1; i <= num; i++)
    {
        Console.Write("$ Число{i}: ");
        int a =int.Parse(Console.ReadLine()!);
        if (a > 0)count++;
    }
    return count;
}
Console.Write("Сколько чисел введете? :");
int a = int.Parse(Console.ReadLine()!);
int  result = Check(a);
Console.WriteLine("$Количество положительных числ :{result}");