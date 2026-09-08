using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("\n1. Add Contact: ");
            Console.WriteLine("2. Search Contact: ");
            Console.WriteLine("3. Delete Contact: ");
            Console.WriteLine("4. Show All");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine().ToUpper();
                Console.Write("Enter phone Number: ");
                string phoneNumber = Console.ReadLine();
                if (!phoneBook.ContainsKey(name))
                {
                    phoneBook.Add(name, phoneNumber);
                    Console.WriteLine("Contact added Successfully");
                }
                else
                {
                    Console.WriteLine("Contact Already Exists");
                }
            }
            else if(choice == "2")
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine().ToUpper();
                if(phoneBook.TryGetValue(name, out string phoneNumber))
                Console.WriteLine(name + "s'number: " + phoneNumber);
                else
                Console.WriteLine("Contact not Found");

            }
            else if(choice == "3")
            {
                Console.Write("Enter Name To Delete: ");
                string name = Console.ReadLine().ToUpper();
                if(phoneBook.Remove(name))
                Console.WriteLine("Contact Deleted Successfully");
                else
                Console.WriteLine("Contact not Found");
            }
            else if(choice == "4")
            {
                if(phoneBook.Count == 0)
                {
                    Console.WriteLine("phoneBook is Enpty");
                }
                else
                {
                    Console.WriteLine("\n---PhoneBook---");
                    foreach (KeyValuePair<string,string>entry in phoneBook)
                    {
                        Console.WriteLine(entry.Key + "->" + entry.Value);
                    }
                }
            }
            else if(choice == "5")
            {
                Console.WriteLine("Bye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}