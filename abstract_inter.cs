using System;

namespace Abstract
{
    /// <summary>
    /// ABSTRACT CLASS HAS TO PROVIDE IMPLEMEMNTATION FOR ALL THE MEMBERS INHERITED FROM THE BAASE CLASS
    /// IF IT DOESNT PROVIDE IMPLEMENTATION FOR ALL THE ABSTARCT MEMBERS IT HAS TO BE DECLARED ABSTRACT AS WELL
    /// ABSTARCT CLASSES CANNOT BE SEALED
    /// IT CAN CONTAIN ABSTRACT MEMBERS BUT NOT MANDATORY
    /// </summary>
   

     //Abract classes can have implementation for some of its members but interfaces cannot have any

    public abstract class Customer
    {
        //private by default
        //can have implementation
        //can inherite from interface and abstract class
        public void Print()
        {
            Console.WriteLine("Print");
        }
    }
    public interface ICustomer
    {
        //public by default
        //cannot have implementation
        //can inherite interfacess only not abstract class
        //classes can inherit from multiple interfaces not abstract classes
        void Print();
    }
    class Program 
    {
        static void Main(string[] args)
        {
           
        }
    }
}
