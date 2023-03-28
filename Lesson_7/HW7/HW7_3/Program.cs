// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
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

    string SerchEl (int[,]arr, int numi, int numj)
    {
        int row = arr.GetLength(0);
	    int column = arr.GetLength(1);
		if (numi > row-1 && numj >column-1)
		Console.WriteLine("такого числа нет");  
	return $"на позиции [{numi},{numj}] стоит число {arr[numi-1,numj-1]}";
    }

	Console.WriteLine("Введите число строк массива :");
	int row_num = int.Parse(Console.ReadLine()!);
	Console.WriteLine("Введите число столбцов массива :");
	int column_num = int.Parse(Console.ReadLine()!);
	Console.WriteLine("Введите диапазон массива :");
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	

	int[,] mass = MassNums(row_num, column_num, start, stop);
    Print(mass);
	Console.WriteLine("Введите первый индекс искомого числа :");
    int vali = int.Parse(Console.ReadLine()!);
	Console.WriteLine("Введите второй индекс искомого числа :");
	int valj = int.Parse(Console.ReadLine()!);

    string result = SerchEl (mass, vali, valj);
    Console.WriteLine(result);
