using System;


namespace Practice
{
    class First
    {
        int x = 100;
        static void Main(String[] args)
        {
            /*Non-static members of a class cannot be accessed from static block, so we cannot print x value here.
            Console.WriteLine(x);*/

            //Creating instance of the class to print the value of x
            First f;
            f = new First();
            Console.WriteLine(f.x);
            Console.ReadLine();
        }
    }
}
