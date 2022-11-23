using System;


namespace Practice
{
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("Constructor is called");

        }
        static void Main()
        {
            ExplicitConstructor obj = new ExplicitConstructor();
            Console.ReadLine();
        }

    }
}

