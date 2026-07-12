using System;
class SumOfDigits
{
    static void Main()
    {
        Console.WriteLine("Enter A Multidigit Number: ");
        int number= Convert.ToInt32(Console.ReadLine());
        int sum=0;
        int temp= number;
        while(temp != 0)
        {
            int digit = temp % 10;
            sum = sum + digit;
            temp = temp / 10;
        
        }
        Console.WriteLine("Sum of "+number+" IS:" +sum);
    }
}