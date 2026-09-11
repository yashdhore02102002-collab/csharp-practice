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
        // 1. Pass झालेले students (marks >= 60), marks नुसार sort
        Console.WriteLine("--- Passed Students ---");
        var passed = students
            .Where(s => s.Marks >= 35)
            .OrderByDescending(s => s.Marks);

        foreach (var s in passed)
            Console.WriteLine(s.Name + " - " + s.Marks);

        // 2. Topper
        var topper = students.First(s => s.Marks == students.Max(x => x.Marks));
        Console.WriteLine("\nTopper: " + topper.Name + " (" + topper.Marks + ")");

        // 3. City-wise average
        Console.WriteLine("\n--- City-wise Average ---");
        var cityAvg = students
            .GroupBy(s => s.City)
            .Select(g => new { City = g.Key, Avg = g.Average(s => s.Marks) });

        foreach (var item in cityAvg)
            Console.WriteLine(item.City + " → " + item.Avg);
    }
   
}