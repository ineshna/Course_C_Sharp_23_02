﻿// Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же
//указание, что такого элемента нет

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
    void EvenPos (int[,]arr)
    {
        int row = arr.GetLength(0);
	    int column = arr.GetLength(1);

        for (int i = 1; i < row; i+=2)
	        for (int j = 1; j < column; j+=2)
	            arr[i, j] = arr[i, j] * arr[i, j];

    }

	
	int row_num = int.Parse(Console.ReadLine()!);
	int column_num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	
	int[,] mass = MassNums(row_num, column_num, start, stop);
	Print(mass);
    EvenPos(mass);
    Print(mass);


