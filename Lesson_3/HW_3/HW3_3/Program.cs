﻿int num = int.Parse(Console.ReadLine()!);

void Div(int n)
{
    int i = 1;
    while(n >= i)    
    {
        Console.WriteLine(Math.Pow(i,3));
        i ++;
    }
}

Div(num);