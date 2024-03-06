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

        int indexToRemove = 1;
        while (numbers.Count > 1)
        {
            List<int> copy = new List<int>(numbers);
          
            for (int i = indexToRemove; i < copy.Count; i += 2)
            {
                numbers.Remove(copy[i]);
            }

            Console.WriteLine($"Видаляємо кожне друге, починаючи з {copy[indexToRemove]}");
            PrintList(numbers);

            indexToRemove = (indexToRemove + 1) % numbers.Count;
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
