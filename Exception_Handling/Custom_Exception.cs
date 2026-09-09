using System;
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
        
    }
}
class Student
{
    private int age;
    public int Age
    {
        get{return age;}
        set
        {
            if(value < 0 || value > 100)
            throw new InvalidAgeException("Age must be Between 0 and 100");
            age = value;
        }
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Student s = new Student();
            Console.Write("Enter Age: ");
            s.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age is : " + s.Age);
        }
        catch(InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input Format.");
        }
    }
}