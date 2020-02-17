

using System;

namespace Abstract
{
    /// <summary>
    /// ABSTRACT CLASS HAS TO PROVIDE IMPLEMEMNTATION FOR ALL THE MEMBERS INHERITED FROM THE BAASE CLASS
    /// IF IT DOESNT PROVIDE IMPLEMENTATION FOR ALL THE ABSTARCT MEMBERS IT HAS TO BE DECLARED ABSTRACT AS WELL
    /// ABSTARCT CLASSES CANNOT BE SEALED
    /// IT CAN CONTAIN ABSTRACT MEMBERS BUT NOT MANDATORY
    /// </summary>
    public abstract class Customer
    {
        public abstract void Print();
        public void Print1()
        {
            Console.WriteLine("Print");
        }


    }
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Customer c = new Program();
            c.Print();
        }

        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
    }
}
