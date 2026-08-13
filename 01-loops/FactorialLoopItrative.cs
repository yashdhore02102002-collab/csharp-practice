using System;

class FactorialLoop
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("Factorial of " + n + " is: " + factorial);
    }
}