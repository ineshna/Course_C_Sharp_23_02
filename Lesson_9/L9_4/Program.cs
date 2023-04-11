//  Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.
int Power(int A, int B)
{
    
    if(B == 0) return 1;
    return A* Power(A, B - 1) ;
}
Console.Write("Введите число A :");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B :");
int numB = int.Parse(Console.ReadLine()!);
Console.Write(Power(numA,numB));
