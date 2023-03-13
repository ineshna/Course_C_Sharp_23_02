// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1

void Fib(int a)
{
    int firstNum = 0;
    int secNum = 1;
    for (int i = 0; i < a; i++)
    {
        Console.Write(firstNum + " ");
        (firstNum, secNum) = (secNum, firstNum + secNum);
    }
}
int a = int.Parse(Console.ReadLine()!);
Fib(a);



// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.


//void Fib(int a)
//{
//    int festNum = 0;
//    int secontNum = 1;
//    for (int i = 0; i < a; i++)
//    {
//        Console.Write(festNum + " ");
//        (festNum, secontNum) = (secontNum, festNum + secontNum);
///    }
//}
//int A = int.Parse(Console.ReadLine()!);
//Fib(A);