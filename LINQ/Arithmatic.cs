using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name;
    public double Marks;
    public string City;
    public Student (string name, double marks, string city)
    {
        Name = name;
        Marks = marks;
        City = city;
    }
}
class Program
{
    static void Main()
    {
     List<Student> students = new List<Student>();
     
        Console.Write("Enter The no of Student: ");
        int n = int.Parse(Console.ReadLine());
        for(int i =0 ; i < n ; i++)
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine().ToUpper();
                Console.Write("Enter Student Mark: ");
                double marks = double.Parse(Console.ReadLine());
                Console.Write("Enter Student City: ");
                string city = Console.ReadLine();
                students.Add(new Student(name, marks, city));
                Console.WriteLine("Student Add Successfully.");
                Console.WriteLine("\n------------------------");
            }
        //Count/Sum/Average/Max/Min
       int totalStudents = students.Count();
       int puneCount = students.Count(s => s.City == "Pune");
       double totalMarks = students.Sum(s => s.Marks);
       double avgMarks = students.Average(s => s.Marks);
       double highestMarks = students.Max(s => s.Marks);
       double lowestMarks = students.Min(s => s.Marks);

       Console.WriteLine("Total Student: " + totalStudents);
       Console.WriteLine("Pune Count: " + puneCount);
       Console.WriteLine("Total marks: " + totalMarks);
       Console.WriteLine("Average: " + avgMarks);
       Console.WriteLine("Highest Mark: " + highestMarks);
       Console.WriteLine("Lowest Mark: " + lowestMarks);
    }
   
}