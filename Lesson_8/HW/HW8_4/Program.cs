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


//int[,] MinEll(int[,] arr, int[,] index)
//{
//    int row = arr.GetLength(0);
//    int column = arr.GetLength(1);
//   int init = arr[0, 0];
  
//    for (int i = 0; i < row; i++)
//    {
//        for (int j = 0; j < column; j++)
//        {
//            if (arr[i, j] <= init)
//            {
//                index[0, 0] = i;
//                index[0, 1] = j;
//                init = arr[i, j];
//            }
//        }
//    }
//    Console.WriteLine($"Mинимальный элемент: {init}");
//    return index;
//}
int[] FindMinEl(int[,] arr)
{
    int minI = 0;
    int minJ = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (arr[i, j] < arr[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
    return new int[] { minI, minJ };
}

int[,] NewMatrix(int[,] arr, int[] indexes)
{
    int line = indexes[0];
    int col = indexes[1];
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    int[,] newArray = new int[row - 1, column  - 1];
    for (int i = 0, a = 0; i < row; i++, a++)
    {
        if (i != line)
        {
            for (int j = 0, b = 0; j < column; j++, b++)
            {
                if (j != col)
                    newArray[a, b] = arr[i, j];
                else b--;
            }
        }
        else a--;
    }
    return newArray;
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

int[] minInd = FindMinEl(mass);
int[,] littleArr = NewMatrix(mass, minInd);
Console.WriteLine(" Вторая  матрица: ");
Print(littleArr);
Console.WriteLine(mass);