using System;

class LinearSearch
{
    static void Main()
    {
        Console.Write("Enter how many numbers: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine(target + " found at index: " + i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine(target + " not found in the array");
        }
    }
}