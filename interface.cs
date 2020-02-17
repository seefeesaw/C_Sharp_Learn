using System;

namespace Interfaces
{
    //No implementation on an interface Just declaration;
    //Interface members are public by default;
    //you can not have an explicit access modifier;
    //Interfaces cannot have fields;
    //If a class or a struct inherit from an interface it 
    //must provide implementation for all interface members

     //
    interface ICustomer1
    {
        void Print1();

    }
    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }
    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Print2");
        }

        public void Print2()
        {
            Console.WriteLine("Print1");
        }
    }
    /// <summary>
    /// Multiple class inheritance is not possible
    /// </summary>
    public class Smaple
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print1();
            c1.Print2();

            //you cannot create an instance of an interface beacuse they are incoplete
            //INTERFACE REFFENCE VARIABLES CAN POINT TO A DERIVED CLASS OBJECT
            ICustomer1 CUST = new Customer();
            CUST.Print1();
        }
    }
}
