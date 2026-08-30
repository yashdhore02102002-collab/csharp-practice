using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Scentence: ");
        string scentence = Console.ReadLine().ToLower();

        string[] words = scentence.Split(' ');
        Dictionary<string, int> frequency = new Dictionary<string, int >();

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
            {
                frequency[word]++; // allready exisist word incriment

            }
            else
            {
                frequency[word] = 1; // For new word            }
            }

        }
     Console.WriteLine("\n--- Word Frequency ---");
     foreach(KeyValuePair<string, int> entery in frequency)
        {
            Console.WriteLine(entery.Key + "->" + entery.Value + "time(s)");

        }
    }
}