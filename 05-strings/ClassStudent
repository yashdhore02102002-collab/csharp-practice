using System;



class Student
{
    // Properties (data)
    public int Id;
    public string Name;
    public int Age;
    public double Marks;

    // Method (behavior)
    public void DisplayInfo()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Marks: " + Marks);
    }

    public string GetGrade()
    {
        if (Marks >= 90) return "A";
        else if (Marks >= 75) return "B";
        else if (Marks >= 60) return "C";
        else return "Fail";
    }
}

class Program
{
    static void Main()
    {
        // Object बनवणे
        Console.Write("Enter the Number of Students :");
        int n = Convert.ToInt32(Console.ReadLine());
        Student[] students = new Student[n];
        for(int i = 0; i < n; i++)
        {
            students[i] = new Student();
            students[i].Id = i+1;
            Console.Write("Enter Name: ");
            students[i].Name = Console.ReadLine().ToUpper();
            Console.Write("Enter Age: ");
            students[i].Age =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks: ");
            students[i].Marks = Convert.ToDouble(Console.ReadLine());

        }
        
        for (int i = 0; i < n; i++)
        {
            students[i].DisplayInfo();
            Console.WriteLine("Grade: " + students[i].GetGrade());
            Console.WriteLine("---");
        }

       
    }
}