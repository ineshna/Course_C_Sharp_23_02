// Напишите цикл, который пинимает на вход два числа(А и В) и
//возводит чисо А в натуральную степень В
Console.WriteLine("Введите Ваше число А ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Ваше число В ");
int b = int.Parse(Console.ReadLine()!);

int DegNum(int c)
{
    int degrynum = a;
    for(int deg = 1; deg < b; deg++)

     degrynum *= a;

    return degrynum;
} 


int result = DegNum(a);
Console.Write(a);
Console.Write(" в степени ");
Console.Write(b);
Console.Write(" равно ");
Console.Write(result);






