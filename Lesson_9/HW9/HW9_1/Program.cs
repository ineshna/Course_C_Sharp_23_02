//  Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.


void SeriesEven(int M, int N)
{
    if( M % 2 != 0) M = M+1;     
     if(M > N) return;
    Console.Write($"{M}, ");
    SeriesEven(M+2,N) ;
}
Console.Write("Введите число N :");
int numN = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M :");
int numM = int.Parse(Console.ReadLine()!);
SeriesEven(numN, numM);