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
	//запалнящий массив
	int[,] MassNums(int row, int column, int from, int to)
	{
	    int[,] arr = new int[row, column];
	
	    for (int i = 0; i < row; i++)
	        for (int j = 0; j < column; j++)
	            arr[i, j] = new Random().Next(from, to);
	    return arr;
	}

    string SerchNum (int[,]arr, int num)
    {
        int row = arr.GetLength(0);
	    int column = arr.GetLength(1);

    
        for (int i = 0; i < row; i++)
	        for (int j = 0; j < column; j++)

             if( arr[i,j] == num)
              return $"[{i+1},{j+1}]";// если бы тут был consol,...то проверил все вхождения
    return "Такого числа нет";   
    }

	
	int row_num = int.Parse(Console.ReadLine()!);
	int column_num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	

	int[,] mass = MassNums(row_num, column_num, start, stop);
    Print(mass);
    int val = int.Parse(Console.ReadLine()!);

    string result = SerchNum(mass, val);
    Console.WriteLine(result);



