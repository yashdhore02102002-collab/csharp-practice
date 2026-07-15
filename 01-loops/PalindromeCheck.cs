

using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int reverse = 0;
        int temp = number;

        while (temp != 0)
        {
            int digit = temp % 10;
            reverse = reverse * 10 + digit;
            temp = temp / 10;
        }

        if (number == reverse)
        {
            Console.WriteLine(number + " is a Palindrome");
        }
        else
        {
            Console.WriteLine(number + " is not a Palindrome");
        }
    }
}