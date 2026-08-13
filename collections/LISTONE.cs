using System;

class Program
{
    static void Main()
    {
        List<string> students = new List<string>();
        
            students.Add("Yash");
            students.Add("Manya");
            students.Add("Dk");

            Console.WriteLine("List of students: "+ students.Count);
            Console.WriteLine("\n---All Students---");

            foreach(string s in students)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("\n First Student: " + students[0]);
        students.Remove("Manya");
        Console.WriteLine("\n After removing Manya:");
        foreach(string s in students)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("\nIs Dk in List:" + students.Contains("Dk"));
        Console.WriteLine("\nIs MAnya in List: " + students.Contains("Manya"));

        students.Insert(1, "Sumya");
        Console.WriteLine("\n After Adding Sumya at Index 1: ");
        foreach(string s in students)
        {
            Console.WriteLine(s);
        }

        students.Clear();
        Console.WriteLine("\n After Clearing List: " + students.Count);
    }
}