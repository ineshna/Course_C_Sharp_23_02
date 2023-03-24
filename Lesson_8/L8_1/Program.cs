// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
//выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
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

    void ReplaceIndex(int[,] array)
    {
        int ArrayRow = array.GetLength(0);
        int ArrayColumn = array.GetLength(1);

        for(int j = 0; j< ArrayColumn; j++)
        {
            (array[0,j], array[ArrayRow -1 ,j]) = ( array[ArrayRow -1 ,j], array[0,j]);
        }
    }

	
	int row_num = int.Parse(Console.ReadLine()!);
	int column_num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	

	int[,] mass = MassNums(row_num, column_num, start, stop);
    Print(mass);
    Console.WriteLine();
    ReplaceIndex(mass);
    Print(mass);

   

    



