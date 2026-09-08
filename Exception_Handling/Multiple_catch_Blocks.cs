using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter Array Size: ");
            int size = int.Parse(Console.ReadLine());

            int[] number = new int [size];
            Console.WriteLine("Enter Index to Access: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Value at index " + index + ":" + number[index]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error:Number Input Invalid");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index Out of Range");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Number Too Large");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Unexpected Error:" + ex.Message);
        }
    }
}