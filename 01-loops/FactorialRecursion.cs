using System;

class FactorialRecursion
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        long result = Factorial(n);
        Console.WriteLine("Factorial of " + n + " is: " + result);
    }
}