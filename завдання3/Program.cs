using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string A = "abc, acdb, cdba, cfb, fhc, cjf, fcd, gkf, fjdks, ccc, mnh, lll, hji";
        Console.WriteLine(A);
        try
        {
            Console.WriteLine("Введiть символ C:");
            char C = Console.ReadKey().KeyChar;

            string[] w = A.Split(',');

            var result = w.FirstOrDefault(str => str.Trim().EndsWith(C));

            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
}
