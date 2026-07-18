using System;

class BubbleSort
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

        // Bubble Sort logic (आधीसारखंच)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.Write("Sorted array: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
