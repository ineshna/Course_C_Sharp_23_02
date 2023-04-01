// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.





void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[] SumRow(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    int[] sums = new int [arr.GetLength(0)];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            sums[i] += arr[i, j];
        }
    }
    return sums;
}
int MinInd(int[] arr)
{
    int minind = 0;
    for(int i = 0; i < arr.Length; i++)
        if (arr[i] < arr[minind])
        minind = i;
    return minind;
}


Console.WriteLine("Введите число строк массива :");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов массива :");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон массива :");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine(" Начальный массив: ");

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

int[] sums = SumRow(mass);
int numline = MinInd(sums);
Console.WriteLine($"Строка с наименьшей суммой элементов - {numline+1}");



