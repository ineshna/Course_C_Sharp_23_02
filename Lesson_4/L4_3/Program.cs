// напишите программу,которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке

void massive (int mas) 
{
    int[] numbers = new int[mas];
    for (int i = 0; i < mas; i++)
    {
        numbers[1] = new Random().Next(0, 2);
        Console.WriteLine(numbers[i]);

    }
}
massive(8);