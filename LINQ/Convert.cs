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
        // LINQ result ला List मध्ये convert करणे
        List<Student> topList = students
         .Where(s => s.Marks > 80)
         .OrderByDescending(s => s.Marks)
         .ToList();

        Console.WriteLine("Top students count: " + topList.Count);
    }
   
}