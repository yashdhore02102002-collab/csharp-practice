using System;

class VowelCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string lower = input.ToLower();
        int count = 0;

        for (int i = 0; i < lower.Length; i++)
        {
            char ch = lower[i];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                count++;
            }
        }

        Console.WriteLine("Total vowels: " + count);
    }
}