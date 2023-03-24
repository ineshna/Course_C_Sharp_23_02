// Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.

Console.WriteLine("Hello, World!");
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

    string SerchEl(int[,]arr, int numi, int numj)
    {
        int row = arr.GetLength(0);
	    int column = arr.GetLength(1);
		if (numi > arr[row,column])
		  Console.WriteLine("Такого числа нет");

    
        for (int i = 0; i < row; i++)
	        for (int j = 0; j < column; j++)

             if( arr[i-1,j-1] == numi && arr[i-1,j-1] == numj)
              return $"на позиции [{numi}{numj}] стоит [{arr[i-1,j-1]}]";// если бы тут был consol,...то проверил все вхождения
    return "Такого числа нет";   
    }

	
	int row_num = int.Parse(Console.ReadLine()!);
	int column_num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	

	int[,] mass = MassNums(row_num, column_num, start, stop);
    Print(mass);
    int vali = int.Parse(Console.ReadLine()!);
	int valj = int.Parse(Console.ReadLine()!);

    string result = SerchEl(mass, vali, valj);
    Console.WriteLine(result);
