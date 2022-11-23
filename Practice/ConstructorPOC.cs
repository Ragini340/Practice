using System;


namespace Practice
{
    class ConstructorPOC
    {
        // Example of implicit constructor
        
        int i;
        // Here we have not assign any value for i and b still we will get the ouptput i=0 and b=false because internally this class contains one implicit constructor and that implicit constructo is going to initialize the variables i and b.
        bool b;
       static void Main(string[] args)
        {
            ConstructorPOC obj = new ConstructorPOC();

            // or we can write ClonstructorPOC c = new Practice.ClonstructorPOC();

            Console.WriteLine("Value of i is :"+obj.i);
            Console.WriteLine("Value of b is :" + obj.b);
       }
    }
}
