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

int SumRow(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int sum = 0;

    for(int i = 0; i < row; i++)
    {
        sum = 0;
        for(int j = 0; j <column; j++)
        {
            sum += arr[i, j];
        }
        Console.WriteLine(sum);
    }
    return sum;
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
SumRow(mass);



