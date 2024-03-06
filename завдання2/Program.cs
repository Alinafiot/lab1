using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        List<string> words = new List<string> { "i", "love", "mama", "and", "papa" };

        Dictionary<int, char> dict = new Dictionary<int, char>()
        {
            { 1, 'a' },
            { 2, 'b' },
            { 3, 'c' },
            { 4, 'd' },
            { 5, 'e' }
        };

        Dictionary<string, char> newDict = new Dictionary<string, char>();

        foreach (string word in words)
        {
            char value;
            if (dict.ContainsKey(word.Length))
            {
                value = dict[word.Length];
            }
            else
            {
                value = default(char);
            }
            newDict.Add(word, value);
        }

        Console.WriteLine("Новий словник:");
        foreach (var kvp in newDict)
        {
            Console.WriteLine($"Ключ: {kvp.Key}, Значення: {kvp.Value}");
        }

        string json = JsonConvert.SerializeObject(newDict, Formatting.Indented);

        Console.WriteLine("Записано у JSON:");
        Console.WriteLine(json);
    }
}
