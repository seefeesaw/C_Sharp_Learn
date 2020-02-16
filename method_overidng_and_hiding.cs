using System;

namespace Method_Overriding_vs_Method_Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new DerivedClass();
            b.Print();
        
        }
    }
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Iam a Base Clasas Print Method");
        }

    }
    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("Iam a Derived class print method");
        }
    }
    public class DerivedClass1 : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("Iam a Derived class print method");
        }
    }
}

