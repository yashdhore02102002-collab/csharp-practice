// See https://aka.ms/new-console-template for more information
using System;

    class EvenOddCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number:");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n%2==0)
        {
            Console.WriteLine(n+" is an Even Number");
        }
        else
        {
            Console.WriteLine(n+" is an Odd Number");
        }
    }
}
