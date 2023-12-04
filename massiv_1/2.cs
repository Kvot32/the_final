using System;

class Program
{
    static void Main()
    {
        int[] array = { 2, 5, 8, 12, 15, 18, 21, 24, 27, 30 };

        int evenCount = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }
        
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }
}
