using System;
 
 class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a Number: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        int Reverse = 0;
        int temp = Number;
        while(temp != 0)
        {
            int digit = temp % 10;
            Reverse = Reverse * 10 + digit;
            temp = temp /10;
        }
        Console.WriteLine("Reverse of the " + Number + " Is: " + Reverse);
    }
}