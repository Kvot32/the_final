using System;

class Program
{
    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNumbers(m + 1, n);
        }
    }

    static void Main()
    {
        Console.Write("Введите значение M: ");
        int mValue = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int nValue = int.Parse(Console.ReadLine());

        PrintNumbers(mValue, nValue);

        Console.ReadLine();
    }
}
