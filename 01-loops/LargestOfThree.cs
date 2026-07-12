using System;
class LargestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter First Number: ");
        int a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        int b= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Third Number: ");
        int c= Convert.ToInt32(Console.ReadLine());
        
        if(a > b && a > c)
        {
            Console.WriteLine("Largest Number is :" +a);
        }
        else if(b > a && b > c)
        {
            Console.WriteLine("Largest Number is :" +b);
        }
        else
        {
            Console.WriteLine("Largest Number is :" +c);
        }
    }
}