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
     Console.WriteLine("Display Above 80 Students: ");
     // 80 पेक्षा जास्त marks असलेले students
var topStudents = students.Where(s => s.Marks > 80);

foreach (var s in topStudents)
    Console.WriteLine(s.Name + " - " + s.Marks); 
     
     
    }
   
}