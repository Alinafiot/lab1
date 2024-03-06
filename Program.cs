using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть n:");
        int n = Convert.ToInt32(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        Console.WriteLine("");
        PrintList(numbers);

        while (numbers.Count > 1)
        {
            for (int i = 1; i < numbers.Count; i += 1)
            {
                numbers.RemoveAt(i);
            }
            Console.WriteLine("Видаляєм кожного другого");
            PrintList(numbers);
        }

        Console.WriteLine("Залишився 1");
    }

    static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}