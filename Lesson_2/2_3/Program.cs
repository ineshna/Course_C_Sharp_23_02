// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void Div(int num1, int num2)
{
    if (num1 % num2 ==0)
        Console.WriteLine("кратно");
    else
        Console.WriteLine("не кратно" + num1 % num2 );
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
Div(a, b);