using System;

class Program
{
    static void Main()
    {

        double[] array = { 3.14, 1.5, 2.718, 0.75, 4.5, 2.2, 6.7, 8.1, 5.3, 9.8 };


        double minElement = array[0];
        double maxElement = array[0];

        foreach (double number in array)
        {
            if (number < minElement)
            {
                minElement = number;
            }

            if (number > maxElement)
            {
                maxElement = number;
            }
        }

        double difference = maxElement - minElement;

        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }
}
