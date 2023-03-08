//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.14212 -> нет 12821 -> да 23432 -> да
Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine()!);
int num5 = num %10;
int num4 = num / 10 % 10;
int num2 = num /1000 %10;
int num1 = num /10000;
if (num1 == num5 && num2 ==num4)
{
    Console.WriteLine("число является палиндромом");
}
else
{
  Console.WriteLine("число не является палиндромом");  
}
