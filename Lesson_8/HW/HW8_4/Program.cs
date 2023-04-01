//Задайте двумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


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


int[,] MinEll(int[,] arr, int[,] position)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int init = arr[0, 0];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (array[i, j] <= temp)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                init = arr[i, j];
            }
        }
    }
    Console.WriteLine($"\nMинимальный элемент: {init}");
    return position;
}

void Delete(int[,] arr, int[,] positionSmallElement, int[,] newarr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int k = 0;
    int l = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
            {
                arrayWithoutLines[k, l] = array[i, j];
                l++;
            }
        }
        l = 0;
        if (positionSmallElement[0, 0] != i)
        {
            k++;
        }
    }
}



Console.WriteLine("Введите число строк первой матрицы :");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов первой матрицы :");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон первой матрицы :");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine(" Первая матрица: ");
int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

