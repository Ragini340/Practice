using System;


namespace Practice
{
    class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called and value of i :" + i);
        }
        public void Display()
        {
            Console.WriteLine("Value of X is :" + x);
        }
        static void Main(string[] args)
        {

            ParameterizedConstructor obj1= new ParameterizedConstructor(10);
            ParameterizedConstructor obj2 = new ParameterizedConstructor(20);

            obj1.Display();
            obj2.Display();
            Console.ReadLine();
        }
    }
}
