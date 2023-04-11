// Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.

int Sum(int M, int N)
{
    
    if(M > N) return 0;
    return Sum(M + 1, N) + M;
}
Console.Write("Введите число A :");
int numM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B :");
int numN = int.Parse(Console.ReadLine()!);
Console.Write(Sum(numM,numN));
