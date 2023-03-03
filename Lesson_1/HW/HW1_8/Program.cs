Console.WriteLine("Введите Ваше  число");
int a = int.Parse(Console.ReadLine()!);
int b = a / a ;
int c = 0;
while (b < a)
{ 
   b = (b + 2) ; 
   c = (b - 1) ;
   Console.Write ($" {c}, "); 
}
