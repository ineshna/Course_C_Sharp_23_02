

int N = int.Parse(Console.ReadLine()!);
void TherdN(int N)
{
    if (N >100)
        {
            while (N > 1000)
            {
            N = N / 10;
            //Console.WriteLine(N);
            }
            N =N % 10;
            Console.WriteLine(N);
        }
    else
        Console.WriteLine("Третьей цифры нет" );
}
TherdN(N);