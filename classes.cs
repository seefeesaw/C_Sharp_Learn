using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overloading constructors
            Customer c1 = new Customer("Seefeesaw","Shongwe");
            c1.PrintFullNmae();
            Customer c2 = new Customer();
            c2.PrintFullNmae();
        }
    }
    class Customer
    {
        string _firstName;
        string _lastName;

        //Parameterless Constructor
        public Customer() : this("No firstName Provide","No lastName Provided")
        {

        }

        public Customer(string firstName,string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        public void PrintFullNmae()
        {
            Console.WriteLine("Full Nmae = {0}", this._firstName + " " + this._lastName);
        }

        ~Customer()
        {
            //Clean Up Code

        }
    }
}
