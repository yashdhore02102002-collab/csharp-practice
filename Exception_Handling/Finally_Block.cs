using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter First Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int b = int.Parse(Console.ReadLine());
            int result = a/b;
            Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid Number Format");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Second number cannot be zero");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}