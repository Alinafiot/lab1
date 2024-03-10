using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть кількість чисел:");
        int N = Convert.ToInt32(Console.ReadLine());

        List<int> numbers = new List<int>();
      
        for (int i = 1; i <= N; i++)
        {
            numbers.Add(i);
        }

        int step = 2;

        while (numbers.Count > 1)
        {
            List<int> removedNumbers = new List<int>();
            int indexToRemove = 1;

            while (indexToRemove < numbers.Count)
            {
                removedNumbers.Add(numbers[indexToRemove]);
                numbers.RemoveAt(indexToRemove);
                indexToRemove += step - 1;
            }

            Console.WriteLine("Цифри, що залишились:");
            Console.WriteLine(string.Join(", ", numbers));

        }

        Console.WriteLine("Залишилося останнє число: " + numbers[0]);
    }
}

