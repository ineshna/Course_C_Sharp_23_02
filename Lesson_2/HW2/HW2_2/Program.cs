int TwoNum(int num)
{
    Console.WriteLine(num);
    int num1 = (num / 100 *10) +(num % 10);
//    int num2 = num % 10;
//    if (num1 >num2) return num1;
    return num1;
}

int result = TwoNum(new Random().Next(100, 1000));
Console.WriteLine(result);