//Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для пользователя.
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

    bool Chek(int row, int column)
    {
        bool result = row != column;
        return result;
    }
    string RowToColomn(int[,]array)
    {
        if(Chek(array.GetLength(0), array.GetLength(1))) return "No";

        for (int i = 0; i<array.GetLength(0); i++)
        {
            for(int j = 0; j<i; j++)
            {
                (array[i,j],array[j,i]) = (array[j,i], array[i,j]);
            }
        }
        Print(array);
        return "Yes";
    }

	
	int row_num = int.Parse(Console.ReadLine()!);
	int column_num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	

	int[,] mass = MassNums(row_num, column_num, start, stop);
    Print(mass);
    Console.WriteLine();
    string result = RowToColomn(mass);
    Console.WriteLine(result);
   