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




    string AvSum (int[,]arr)
    {
        int row = arr.GetLength(0);
	    int column = arr.GetLength(1);
        for(int j = 0; j < column; j++)
        {
          double avarsum = 0;
            for (int i = 0; i < row; i++)
            {
                avarsum = (avarsum + arr[i, j]);
            }
            avarsum = avarsum / row;
            Console.Write(avarsum + "; ");  
        }
		  
	return "-cреднее арифметическое элементов в каждом столбце";
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
	

    string result = AvSum (mass);
    Console.WriteLine(result);
