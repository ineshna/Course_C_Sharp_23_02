//Задайте значения M и N. Напишите программу, которая
//рекурсивно выведет все натуральные числа в промежутке от M до N.


void NumsFromTo(int M, int N)
{
    
    if(M > N) return;
    NumsFromTo(M,N - 1);
    Console.Write($"{N}, ");
}
Console.Write("Введите число M :");
Console.Write("Введите число N :");
int numM = int.Parse(Console.ReadLine()!);
int numN = int.Parse(Console.ReadLine()!);
NumsFromTo(numM, numN);