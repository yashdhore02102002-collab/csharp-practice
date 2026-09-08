using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter A Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + num);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Invalid Input. Please Enter a valid Integer.");
            Console.WriteLine("Details: " + ex.Message);
        }
    }
}