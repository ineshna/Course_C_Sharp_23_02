// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами 
//такой длины.

void Triangle(int a, int b, int c)
{
    if (a < b + c & b < a + c & c < a + b)
    Console.WriteLine("Yes");

    else
    Console.WriteLine("No");
}
int n1 =int.Parse(Console.ReadLine()!);
int n2 =int.Parse(Console.ReadLine()!);
int n3 =int.Parse(Console.ReadLine()!);
Triangle(n1, n2, n3);
