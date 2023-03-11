// Напишите программму, которая принмиает на вход число N и
//выдает произведение от 1 до N
Console.WriteLine("Введите число");
int CompositionNum(int num)
{
    int m= 1;
    for(int i = 1; i <= num; i++)

     m *= i;

    return m;
} 

int a = int.Parse(Console.ReadLine()!);
int result = CompositionNum(a);
Console.Write("произведение числа ");
Console.Write(a);
Console.Write(" является ");
Console.Write(result);