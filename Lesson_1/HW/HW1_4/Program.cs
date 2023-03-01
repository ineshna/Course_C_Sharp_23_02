Console.WriteLine("Введите Ваше первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Ваше второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Ваше второе число");
int c = int.Parse(Console.ReadLine()!);
if (a > b)
{
    a = Mnum;
}
else
{
    b = Mnum;
}
if (b > c)
{
    b = Mnum;
}
else
{
    c = Mnum;
}
if (c > a)
{
    c = Mnum;
}
else
{
    a = Mnum;
}
Console.WriteLine( $"{Mnum} max");