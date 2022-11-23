using System;

// ReadLine() is a method of Console class to read a line from the standard input stream

namespace Practice
{
    class ReadLineFunction
    {
        static void Main(string[] args)
        {
            string fname, lname;  //String variables
            Console.Write("Please enter your first name:");
            fname = Console.ReadLine();  //Taking the firstname from the user
            Console.Write("Please Enter your last name:");
            lname = Console.ReadLine(); // Taking the second name from the user 
            Console.WriteLine("Your full name is :" + fname + " " +
                " " + lname);
        }
    }
}
