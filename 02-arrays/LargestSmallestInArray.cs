using System;

class LargestSmallestInArray
{
    static void Main()
    {
        int[] numbers = { 12, 45, 3, 67, 29, 8 };

        int largest = numbers[0];
        int smallest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }

            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        Console.WriteLine("Largest number: " + largest);
        Console.WriteLine("Smallest number: " + smallest);
    }
}