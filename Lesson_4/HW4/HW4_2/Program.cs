// Напишите программу,которая пинимает на вход число и 
//выдает сумму цифр в числе
Console.WriteLine("Введите Ваше число  ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(number));
int SumNum(int num)
{
    int allsum = 0;
    while (num > 0)
    {
        allsum += num % 10;
        num /=10;

    }
    return allsum;
}