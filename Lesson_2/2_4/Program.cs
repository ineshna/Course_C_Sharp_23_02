// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int N = int.Parse(Console.ReadLine()!);
void Div(int N)
{
    if (N % 7 ==0 & N % 23 == 0)
        Console.WriteLine("кратно");
    else
        Console.WriteLine("не кратно" );
}


Div(N);
