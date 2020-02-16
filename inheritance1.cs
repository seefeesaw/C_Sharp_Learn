using System;

namespace Inheritance
{
    class Program
    {
        public static void Main()
        {
            ChildClass cc = new ChildClass();
        }

    }
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor Called");
        }
        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling parent class")
        {
            Console.WriteLine("ChildClass Constructor Called");
        }
    }
}

