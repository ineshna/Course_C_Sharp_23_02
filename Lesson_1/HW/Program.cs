

Console.WriteLine("Введите Ваше первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Ваше второе число");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine(  $"{a} max");
}
else
{
 Console.WriteLine(  $"{b} max");   
}