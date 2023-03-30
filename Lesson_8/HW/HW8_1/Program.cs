// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
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



void OrderArray(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int newcol = arr.GetLength(1);
    for (int i = 0; i < row ; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < newcol - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
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

Console.WriteLine(" Отсортированный массив: ");
OrderArray(mass);
Print(mass);
