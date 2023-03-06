int D = int.Parse(Console.ReadLine()!);
void Days(int D)
{
    if (D < 8)
        {
            if (D <=5 )
            {
               Console.WriteLine("рабочий день"); 
            }
            else
            Console.WriteLine("выходной день"); 
        }
    else
        Console.WriteLine("Не корректная цифра" );
}
Days(D);