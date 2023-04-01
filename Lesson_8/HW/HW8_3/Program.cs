//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
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




void Multiply(int[,] arr1, int[,] arr2, int[,] arrend)
{
    int row1 = arr1.GetLength(0);
    int column1 = arr1.GetLength(1);
    int row2 = arr2.GetLength(0);
    int column2 = arr2.GetLength(1);
    int rowend = arrend.GetLength(0);
    int columnend = arrend.GetLength(1);

    if (column1 != column2 && row1 != row2 )
    Console.WriteLine("Умножение матриц невозможно.Размеры матриц должны быть одинаковыми");


    for (int i = 0; i < rowend; i++)
    {
        for (int j = 0; j < columnend; j++)
        {
            int sum = 0;
            for (int k = 0; k < column1; k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            arrend[i, j] = sum;
        }
    }
}



Console.WriteLine("Введите число строк первой матрицы :");
int row_num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов первой матрицы :");
int column_num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон первой матрицы :");
int start1 = int.Parse(Console.ReadLine()!);
int stop1 = int.Parse(Console.ReadLine()!);



Console.WriteLine("Введите число второй матрицы :");
int row_num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число второй матрицы :");
int column_num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон второй матрицы :");
int start2 = int.Parse(Console.ReadLine()!);
int stop2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(" Первая матрица: ");
int[,] mass1 = MassNums(row_num1, column_num1, start1, stop1);
Print(mass1);


Console.WriteLine(" Вторая матрица: ");
int[,] mass2 = MassNums(row_num2, column_num2, start2, stop2);
Print(mass2);


int[,] massend = new int[row_num1, column_num2];
Multiply(mass1, mass2, massend);
Console.WriteLine("Произведение первой и второй матриц:");
Print(massend);