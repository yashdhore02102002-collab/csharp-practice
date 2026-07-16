using System;

class BubbleSort
{
    static void Main()
    {
        int[] numbers = { 45, 12, 67, 3, 29, 8 };
        int n = numbers.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Swap kar
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