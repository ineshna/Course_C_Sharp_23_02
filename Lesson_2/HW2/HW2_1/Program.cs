
int TakeNum(int num)
{
    Console.WriteLine(num);
    return num / 10 % 10;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);