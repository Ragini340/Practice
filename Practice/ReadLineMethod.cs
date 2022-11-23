using System; //Defining the system package


namespace Practice  //Project name
{
    class ReadLineMethod
    {
        static void Main(string[] args) //Defining the main function
        {
            string name;   //String variable name
            Console.WriteLine("Hello what is your name?");
            name = Console.ReadLine();  //Taking an input from the user
            Console.WriteLine("Hi " + name+" Welcome to the FAI");  //Printing the output
        }
    }
}
