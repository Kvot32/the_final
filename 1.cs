using System;

class Program
{
    static void Main()
    {
        int[] array = { 14, 26, 34, 42, 53, 60, 78, 82, 92, 100 };

        int count = 0;

        foreach (int number in array)
        {
            if (number >= 20 && number <= 90)
            {
                count++;
            }
        }
        Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20, 90]: {count}");
    }
}
