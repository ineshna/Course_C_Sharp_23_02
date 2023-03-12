

Console.WriteLine("Введите число");
// напишите программу, которая приримает
//на вход число(А) и выдает сумму числе от 1 до А

int LengthNum(int num)
{
    int a = 0;
    for(int i = 1;num > 0; i++)
       {num = num/10;
       a++;
       }
    return a;
}    
int num = int.Parse(Console.ReadLine()!);
int result = LengthNum(num);
Console.Write("число ");
Console.Write(num);
Console.Write(" состоит из ");
Console.Write(result);
Console.Write(" цифр");