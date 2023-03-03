Console.WriteLine("Введите Ваше первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Ваше второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Ваше второе число");
int c = int.Parse(Console.ReadLine()!);
int maxnum = 0;
if (a > b)
{
    maxnum = a;
}
if (b > maxnum)
{
    maxnum = b;
}
if(c > maxnum)
{
    maxnum = c;
}
Console.WriteLine($"{maxnum} = max "); 