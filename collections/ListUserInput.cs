using System;
using System.Data.Common;

class Student
{
   public string Name;
   public double Marks;
   public int Id;
   public string Grade;

   public Student(string name, double marks,int id,string grade)
    {
        Name = name;
        Marks = marks;
        Id = id;
        Grade = grade;
    }

   public void DisplayInfo()
    {
        Console.WriteLine("Id: " + Id + " Student Name: " + Name + " |Marks: " + Marks + " |Grade: " + Grade);
    }

}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        Console.WriteLine("Enter the Number of Students: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i<n; i++)
        {
            int Id = i + 1;
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Students Marks: ");
            double marks = double.Parse(Console.ReadLine());
            string Grade;
            if(marks >= 90)
            {
                Grade = "A";
            }
            else if(marks >= 70)
            {
                Grade = "B";
            }
            else
            {
                Grade = "C";
            }
            students.Add (new Student(name, marks, Id ,Grade));
            
        }
        Console.WriteLine("\n---All Students Information---");
        foreach (Student s in students)
        {
            s.DisplayInfo();
        }
        Console.WriteLine("\nTotal Students: " + students.Count);
    }
}